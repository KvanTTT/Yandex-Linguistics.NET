using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
			var allLangs = (Lang[])Enum.GetValues(typeof(Lang));
			LangPair[] result = response.Select(str =>
			{
				var inOut = str.Split('-');
				return new LangPair(
					(Lang)Enum.Parse(typeof(Lang), inOut[0].Remove(1).ToUpperInvariant() + inOut[0].Substring(1)),
					(Lang)Enum.Parse(typeof(Lang), inOut[1].Remove(1).ToUpperInvariant() + inOut[1].Substring(1)));
			}).ToArray();
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
				if (lang.InputLang == Lang.None)
					request.AddParameter("lang", lang.OutputLang.ToString().ToLowerInvariant());
				else
					request.AddParameter("lang", lang.ToString().ToLowerInvariant());
			}
			if (format.HasValue)
				request.AddParameter("format", format.ToString().ToLowerInvariant());
			if (options)
				request.AddParameter("options", "1");

			return SendRequest<Translation>(request);
		}
	}
}