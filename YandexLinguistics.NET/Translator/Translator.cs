using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET
{
	public class Translator
	{
		protected RestClient _client;
		protected string _key;

		public Translator(string dictionayKey, string baseUrl = "https://translate.yandex.net/api/v1.5/tr")
		{
			_key = dictionayKey;
			_client = new RestClient(baseUrl);
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
				var error = deserializer.Deserialize<YandexError>(response);
				throw new YandexLinguisticsException(error);
			}
		}

		public Lang DetectLang(string text)
		{
			RestRequest request = new RestRequest("detect");
			request.AddParameter("key", _key);
			request.AddParameter("text", text);

			RestResponse response = (RestResponse)_client.Execute(request);
			XmlAttributeDeserializer deserializer = new XmlAttributeDeserializer();
			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				var detectedLang = deserializer.Deserialize<DetectedLang>(response);
				return detectedLang.Lang;
			}
			else
			{
				var error = deserializer.Deserialize<YandexError>(response);
				throw new YandexLinguisticsException(error);
			}
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

			RestResponse response = (RestResponse)_client.Execute(request);
			XmlAttributeDeserializer deserializer = new XmlAttributeDeserializer();
			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				var translation = deserializer.Deserialize<Translation>(response);
				return translation;
			}
			else
			{
				var error = deserializer.Deserialize<YandexError>(response);
				throw new YandexLinguisticsException(error);
			}
		}
	}
}
