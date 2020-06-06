using RestSharp;
using System.Collections.Generic;
using System.Linq;

namespace YandexLinguistics.NET
{
	public class Translator : YandexService
	{
		public Translator(string translatorKey, string baseUrl = "https://translate.yandex.net/api/v1.5/tr")
			: base(translatorKey, baseUrl)
		{
		}

		public LangPair[] GetLangs()
		{
			RestRequest request = new RestRequest("getLangs");
			request.AddParameter("key", _key);

			var response = SendRequest<List<string>>(request);
			LangPair[] result = response.Select(str => LangPair.Parse(str)).ToArray();
			return result;
		}

		public Lang DetectLang(string text)
		{
			RestRequest request = new RestRequest("detect");
			request.AddParameter("key", _key);
			request.AddParameter("text", text);

			return SendRequest<DetectedLang>(request).Lang;
		}

		public Translation Translate(string text, LangPair lang, OutputFormat? format = null, bool options = false)
		{
			RestRequest request = new RestRequest("translate");
			request.AddParameter("key", _key);
			request.AddParameter("text", text);
			if (lang.OutputLang != Lang.None)
			{
				request.AddParameter("lang",
					lang.InputLang == Lang.None
						? lang.OutputLang.ToString().ToLowerInvariant()
						: lang.ToString().ToLowerInvariant());
			}
			if (format.HasValue)
				request.AddParameter("format", format.ToString().ToLowerInvariant());
			if (options)
				request.AddParameter("options", "1");

			return SendRequest<Translation>(request);
		}
	}
}