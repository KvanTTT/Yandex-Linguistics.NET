using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET
{
	public class Dictionary : YandexService
	{
		public Dictionary(string dictionayKey, string baseUrl = "https://dictionary.yandex.net/api/v1/dicservice")
			: base(dictionayKey, baseUrl)
		{
		}

		public LangPair[] GetLangs()
		{
			RestRequest request = new RestRequest("getLangs");
			request.AddParameter("key", _key);

			var response = SendRequest<List<string>>(request);
			LangPair[] result = response.Select(str =>
			{
				var inOut = str.Split('-');
				return new LangPair(
					(Lang)Enum.Parse(typeof(Lang), inOut[0].Remove(1).ToUpperInvariant() + inOut[0].Substring(1)),
					(Lang)Enum.Parse(typeof(Lang), inOut[1].Remove(1).ToUpperInvariant() + inOut[1].Substring(1)));
			}).ToArray();
			return result;
		}

		public DicResult Lookup(LangPair lang, string text, string ui = null, LookupOptions flags = 0)
		{
			RestRequest request = new RestRequest("lookup");
			request.AddParameter("key", _key);
			request.AddParameter("lang", lang.ToString().ToLowerInvariant());
			request.AddParameter("text", text);
			
			if (!string.IsNullOrEmpty(ui))
				request.AddParameter("ui", ui);
			if (flags != 0)
				request.AddParameter("flags", (int)flags);

			return SendRequest<DicResult>(request);
		}
	}
}
