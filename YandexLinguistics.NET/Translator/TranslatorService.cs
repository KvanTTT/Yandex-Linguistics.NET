using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YandexLinguistics.NET.Translator
{
	public class TranslatorService : YandexService
	{
		public TranslatorService(string translatorKey, string baseUrl = "https://translate.yandex.net/api/v1.5/tr.json/")
			: base(translatorKey, baseUrl)
		{
		}

		public async Task<IReadOnlyList<LanguagePair>> GetLanguagesAsync()
		{
			var request = CreateRequestBuilder("getLangs");
			var response = await GetAndDeserializeAsync<Directions>(request).ConfigureAwait(false);
			return response.TranslatorDirections.Select(LanguagePair.Parse).ToArray();
		}

		public async Task<Language> DetectLanguageAsync(string text)
		{
			var request = CreateRequestBuilder("detect");
			AddParameter(request, "text", text);
			var detectedLanguage = await GetAndDeserializeAsync<DetectedLanguage>(request).ConfigureAwait(false);
			return detectedLanguage.Language;
		}

		public Task<Translation> TranslateAsync(string text, LanguagePair language, OutputFormat? format = null, bool options = false)
		{
			var request = CreateRequestBuilder("translate");
			AddParameter(request, "text", text);
			if (language.OutputLanguage != Language.None)
			{
				AddParameter(request, "lang",
					language.InputLanguage == Language.None
						? language.OutputLanguage.ToString().ToLowerInvariant()
						: language.ToString().ToLowerInvariant());
			}
			if (format.HasValue)
				AddParameter(request, "format", format.ToString().ToLowerInvariant());
			if (options)
				AddParameter(request, "options", "1");

			return GetAndDeserializeAsync<Translation>(request);
		}
	}
}