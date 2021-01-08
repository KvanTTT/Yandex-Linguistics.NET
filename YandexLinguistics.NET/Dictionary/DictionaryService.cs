using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YandexLinguistics.NET.Dictionary
{
	public class DictionaryService : YandexService
	{
		public DictionaryService(string dictionaryKey, string baseUrl = "https://dictionary.yandex.net/api/v1/dicservice.json")
			: base(dictionaryKey, baseUrl)
		{
		}

		public async Task<IReadOnlyList<LanguagePair>> GetLanguagesAsync()
		{
			var request = CreateRequestBuilder("getLangs");

			var pairs = await GetAndDeserializeAsync<List<string>>(request);

			return pairs.Select(str =>
			{
				var inOut = str.Split('-');
				return new LanguagePair(
					(Language) Enum.Parse(typeof(Language), inOut[0], true),
					(Language) Enum.Parse(typeof(Language), inOut[1], true));
			}).ToArray();
		}

		public async Task<DictionaryResult> LookupAsync(LanguagePair languagePair, string text, string ui = null, LookupOptions flags = 0)
		{
			var request = CreateRequestBuilder("lookup");
			AddParameter(request, "lang", languagePair.ToString().ToLowerInvariant());
			AddParameter(request, "text", text);

			if (!string.IsNullOrEmpty(ui))
				AddParameter(request, "ui", ui);

			if (flags != 0)
				AddParameter(request, "flags", ((int)flags).ToString());

			return await GetAndDeserializeAsync<DictionaryResult>(request).ConfigureAwait(false);
		}
	}
}
