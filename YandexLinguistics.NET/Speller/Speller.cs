using RestSharp;
using RestSharp.Deserializers;
using System.Collections.Generic;

namespace YandexLinguistics.NET
{
	public class Speller
	{
		protected RestClient _client = new RestClient("http://speller.yandex.net/services/spellservice");

		public Speller()
		{
		}

		public SpellResult CheckText(string text, Lang[] lang = null, SpellerOptions? options = null, OutputFormat? format = null)
		{
			RestRequest request = new RestRequest("checkText");
			request.AddParameter("text", text);
			if (lang != null && lang.Length != 0)
				request.AddParameter("lang", string.Join(",", lang.ToString().ToLowerInvariant()));
			if (options.HasValue)
				request.AddParameter("options", (int)options.Value);
			if (format.HasValue)
				request.AddParameter("format", format.Value.ToString().ToLowerInvariant());

			RestResponse response = (RestResponse)_client.Execute(request);
			XmlAttributeDeserializer deserializer = new XmlAttributeDeserializer();
			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				var spellResult = deserializer.Deserialize<SpellResult>(response);
				return spellResult;
			}
			else
			{
				var error = deserializer.Deserialize<YandexError>(response);
				throw new YandexLinguisticsException(error);
			}
		}

		public ArrayOfSpellResult CheckTexts(string[] texts, Lang[] lang = null, SpellerOptions? options = null, OutputFormat? format = null)
		{
			RestRequest request = new RestRequest("checkTexts");
			foreach (var text in texts)
				request.AddParameter("text", text);
			if (lang != null && lang.Length != 0)
				request.AddParameter("lang", string.Join(",", lang.ToString().ToLowerInvariant()));
			if (options.HasValue)
				request.AddParameter("options", (int)options.Value);
			if (format.HasValue)
				request.AddParameter("format", format.Value.ToString().ToLowerInvariant());

			RestResponse response = (RestResponse)_client.Execute(request);
			XmlAttributeDeserializer deserializer = new XmlAttributeDeserializer();
			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				var spellResult = deserializer.Deserialize<ArrayOfSpellResult>(response);
				return spellResult;
			}
			else
			{
				var error = deserializer.Deserialize<YandexError>(response);
				throw new YandexLinguisticsException(error);
			}
		}

		public static Dictionary<int, CharMistakeType> DiffCharPoses(string word, string steer)
		{
			var result = new Dictionary<int, CharMistakeType>();

			if (string.IsNullOrEmpty(word) || string.IsNullOrEmpty(steer))
				return result;

			if (word.Length == steer.Length)
			{
				for (int i = 0; i < steer.Length; i++)
					if (word[i] != steer[i])
						result.Add(i, CharMistakeType.Substitution);
			}
			else if (word.Length < steer.Length)
			{
				int minInd = 0;
				int minDiff = word.Length;
				for (int i = 0; i <= steer.Length - word.Length; i++)
				{
					int diff = 0;
					for (int j = 0; j < word.Length; j++)
						if (word[j] != steer[j + i])
							diff++;
					if (diff < minDiff)
					{
						minInd = i;
						minDiff = diff;
					}
				}
				for (int j = 0; j < minInd; j++)
					result.Add(j, CharMistakeType.Insertion);
				for (int j = 0; j < word.Length; j++)
					if (word[j] != steer[j + minInd])
						result.Add(j + minInd, CharMistakeType.Substitution);
				for (int j = word.Length + minInd; j < steer.Length; j++)
					result.Add(j, CharMistakeType.Insertion);
			}

			return result;
		}

		public static Dictionary<int, CharMistakeType> LevenshteinDiff(string word, string steer)
		{
			int w_length = word.Length;
			int s_length = steer.Length;
			KeyValuePair<int, CharMistakeType>[,] d = new KeyValuePair<int, CharMistakeType>[w_length + 1, s_length + 1];
			var result = new Dictionary<int, CharMistakeType>();

			if (w_length == 0)
			{
				for (int i = 0; i < s_length; i++)
					result.Add(i, CharMistakeType.Insertion);
				return result;
			}

			if (s_length == 0)
			{
				for (int i = 0; i < w_length; i++)
					result.Add(i, CharMistakeType.Deletion);
				return result;
			}

			for (int i = 0; i <= w_length; i++)
				d[i, 0] = new KeyValuePair<int, CharMistakeType>(i, CharMistakeType.None);

			for (int j = 0; j <= s_length; j++)
				d[0, j] = new KeyValuePair<int, CharMistakeType>(j, CharMistakeType.None);

			for (int i = 1; i <= w_length; i++)
			{
				for (int j = 1; j <= s_length; j++)
				{
					if (steer[j - 1] == word[i - 1])
						d[i, j] = new KeyValuePair<int, CharMistakeType>(d[i - 1, j - 1].Key, CharMistakeType.None);
					else
					{
						d[i, j] = new KeyValuePair<int, CharMistakeType>(d[i - 1, j].Key + 1, CharMistakeType.Deletion);

						int val = d[i, j - 1].Key + 1;
						if (val < d[i, j].Key)
							d[i, j] = new KeyValuePair<int, CharMistakeType>(val, CharMistakeType.Insertion);

						val = d[i - 1, j - 1].Key + 1;
						if (val < d[i, j].Key)
							d[i, j] = new KeyValuePair<int, CharMistakeType>(val, CharMistakeType.Substitution);
					}
				}
			}

			int w_ind = word.Length;
			int s_ind = steer.Length;
			while (w_ind >= 0 && s_ind >= 0)
			{
				switch (d[w_ind, s_ind].Value)
				{
					case CharMistakeType.None:
						w_ind--;
						s_ind--;
						break;
					case CharMistakeType.Substitution:
						result.Add(s_ind - 1, d[w_ind, s_ind].Value);
						w_ind--;
						s_ind--;
						break;
					case CharMistakeType.Deletion:
						result.Add(s_ind, d[w_ind, s_ind].Value);
						w_ind--;
						break;
					case CharMistakeType.Insertion:
						result.Add(s_ind - 1, d[w_ind, s_ind].Value);
						s_ind--;
						break;
				}
			}

			return result;
		}
	}
}
