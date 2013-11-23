using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET
{
	public class Dictionary
	{
		protected RestClient _client = new RestClient("https://dictionary.yandex.net/api/v1/dicservice/");
		protected string _key;

		public Dictionary(string dictionayKey)
		{
			_key = dictionayKey;
		}

		public LangPair[] GetLangs()
		{
			RestRequest request = new RestRequest("getLangs");
			request.AddParameter("key", _key);

			RestResponse response = (RestResponse)_client.Execute(request);
			XmlAttributeDeserializer deserializer = new XmlAttributeDeserializer();
			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				var strs = deserializer.Deserialize<List<string>>(response);
				
				var allLangs = (Lang[])Enum.GetValues(typeof(Lang));
				LangPair[] result = strs.Select(str => 
				{
					var inOut = str.Split('-');
					return new LangPair(
						(Lang)Enum.Parse(typeof(Lang), inOut[0].Remove(1).ToUpperInvariant() + inOut[0].Substring(1)),
						(Lang)Enum.Parse(typeof(Lang), inOut[1].Remove(1).ToUpperInvariant() + inOut[1].Substring(1)));
				}).ToArray();
				return result;
			}
			else
			{
				var error = deserializer.Deserialize<Error>(response);
				throw new YandexLinguisticsException(error);
			}
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

			RestResponse response = (RestResponse)_client.Execute(request);
			XmlAttributeDeserializer deserializer = new XmlAttributeDeserializer();
			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				var completeResponse = deserializer.Deserialize<DicResult>(response);
				return completeResponse;
			}
			else
			{
				var error = deserializer.Deserialize<Error>(response);
				throw new YandexLinguisticsException(error);
			}
		}
	}
}
