using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace YandexLinguistics.NET
{
	public class Dictionary : YandexService
	{
		public Dictionary(string dictionaryKey, string baseUrl = "https://dictionary.yandex.net/api/v1/dicservice")
			: base(dictionaryKey, baseUrl)
		{
		}

		public LangPair[] GetLanguages()
		{
			RestRequest request = new RestRequest("getLangs");
			request.AddParameter("key", _key);

			var response = SendRequest<List<string>>(request);
			LangPair[] result = response.Select(str =>
			{
				var inOut = str.Split('-');
				return new LangPair(
					(Lang)Enum.Parse(typeof(Lang), inOut[0], true),
					(Lang)Enum.Parse(typeof(Lang), inOut[1], true));
			}).ToArray();
			return result;
		}

		public DicResult Lookup(LangPair langPair, string text, string ui = null, LookupOptions flags = 0)
		{
			RestRequest request = new RestRequest("lookup");
			request.AddParameter("key", _key);
			request.AddParameter("lang", langPair.ToString().ToLowerInvariant());
			request.AddParameter("text", text);

			if (!string.IsNullOrEmpty(ui))
				request.AddParameter("ui", ui);
			if (flags != 0)
				request.AddParameter("flags", (int)flags);

			return SendRequest<DicResult>(request);
		}
	}
}
