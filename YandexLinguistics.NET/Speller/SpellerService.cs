﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace YandexLinguistics.NET.Speller
{
	public class SpellerService : YandexService
	{
		public SpellerService(string baseUrl = "http://speller.yandex.net/services/spellservice.json/")
			: base("", baseUrl)
		{
		}

		public async Task<IReadOnlyList<Error>> CheckTextAsync(string text, Language[] lang = null, SpellerOptions? options = null,
			OutputFormat? format = null)
		{
			var result = await CheckTextsAsync(new[] {text}, lang, options, format).ConfigureAwait(false);
			return result[0];
		}

		public Task<IReadOnlyList<IReadOnlyList<Error>>> CheckTextsAsync(string[] texts, Language[] lang = null, SpellerOptions? options = null, OutputFormat? format = null)
		{
			var request = CreateRequestBuilder("checkTexts");
			foreach (var text in texts)
				AddParameter(request, "text", text);
			if (lang != null && lang.Length != 0)
				AddParameter(request, "lang", string.Join(",", lang.ToString().ToLowerInvariant()));
			if (options.HasValue)
				AddParameter(request, "options", ((int) options.Value).ToString());
			if (format.HasValue)
				AddParameter(request, "format", format.Value.ToString().ToLowerInvariant());

			return GetAndDeserializeAsync<IReadOnlyList<IReadOnlyList<Error>>>(request);
		}

		public static List<Mistake> OptimalStringAlignmentDistance(
			string word, string correctedWord,
			bool transposition = true,
			int substitutionCost = 1,
			int insertionCost = 1,
			int deletionCost = 1,
			int transpositionCost = 1)
		{
			int wLength = word.Length;
			int cwLength = correctedWord.Length;
			var d = new KeyValuePair<int, CharMistakeType>[wLength + 1, cwLength + 1];
			var result = new List<Mistake>(Math.Max(wLength, cwLength));

			if (wLength == 0)
			{
				for (int i = 0; i < cwLength; i++)
					result.Add(new Mistake(i, CharMistakeType.Insertion));
				return result;
			}

			for (int i = 0; i <= wLength; i++)
				d[i, 0] = new KeyValuePair<int, CharMistakeType>(i, CharMistakeType.None);

			for (int j = 0; j <= cwLength; j++)
				d[0, j] = new KeyValuePair<int, CharMistakeType>(j, CharMistakeType.None);

			for (int i = 1; i <= wLength; i++)
			{
				for (int j = 1; j <= cwLength; j++)
				{
					bool equal = correctedWord[j - 1] == word[i - 1];
					int delCost = d[i - 1, j].Key + deletionCost;
					int insCost = d[i, j - 1].Key + insertionCost;
					int subCost = d[i - 1, j - 1].Key;
					if (!equal)
						subCost += substitutionCost;
					int transCost = int.MaxValue;
					if (transposition && i > 1 && j > 1 && word[i - 1] == correctedWord[j - 2] && word[i - 2] == correctedWord[j - 1])
					{
						transCost = d[i - 2, j - 2].Key;
						if (!equal)
							transCost += transpositionCost;
					}

					int min = delCost;
					CharMistakeType mistakeType = CharMistakeType.Deletion;
					if (insCost < min)
					{
						min = insCost;
						mistakeType = CharMistakeType.Insertion;
					}
					if (subCost < min)
					{
						min = subCost;
						mistakeType = equal ? CharMistakeType.None : CharMistakeType.Substitution;
					}
					if (transCost < min)
					{
						min = transCost;
						mistakeType = CharMistakeType.Transposition;
					}

					d[i, j] = new KeyValuePair<int, CharMistakeType>(min, mistakeType);
				}
			}

			int wInd = wLength;
			int cwInd = cwLength;
			while (wInd >= 0 && cwInd >= 0)
			{
				switch (d[wInd, cwInd].Value)
				{
					case CharMistakeType.None:
						wInd--;
						cwInd--;
						break;
					case CharMistakeType.Substitution:
						result.Add(new Mistake(cwInd - 1, CharMistakeType.Substitution));
						wInd--;
						cwInd--;
						break;
					case CharMistakeType.Deletion:
						result.Add(new Mistake(cwInd, CharMistakeType.Deletion));
						wInd--;
						break;
					case CharMistakeType.Insertion:
						result.Add(new Mistake(cwInd - 1, CharMistakeType.Insertion));
						cwInd--;
						break;
					case CharMistakeType.Transposition:
						result.Add(new Mistake(cwInd - 2, CharMistakeType.Transposition));
						wInd -= 2;
						cwInd -= 2;
						break;
				}
			}
			if (d[wLength, cwLength].Key > result.Count)
			{
				int delMistakesCount = d[wLength, cwLength].Key - result.Count;
				for (int i = 0; i < delMistakesCount; i++)
					result.Add(new Mistake(0, cwLength > wLength ? CharMistakeType.Insertion : CharMistakeType.Deletion));
			}

			result.Reverse();

			return result;
		}
	}
}
