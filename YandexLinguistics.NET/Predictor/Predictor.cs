using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp.Serialization.Xml;

namespace YandexLinguistics.NET
{
	public class Predictor
	{
		private readonly RestClient _client;
		private readonly string _key;

		public static readonly IReadOnlyCollection<Lang> Languages = new []
		{
			Lang.Ru,
			Lang.En,
			Lang.Pl,
			Lang.Uk,
			Lang.De,
			Lang.Fr,
			Lang.Es,
			Lang.It,
			Lang.Tr,
			Lang.Az,
			Lang.Be,
			Lang.Bg,
			Lang.Cs,
			Lang.Ro,
			Lang.Sr,
			Lang.Ca,
			Lang.Da,
			Lang.El,
			Lang.Et,
			Lang.Fi,
			Lang.Hu,
			Lang.Lt,
			Lang.Lv,
			Lang.Mhr,
			Lang.Mk,
			Lang.Mrj,
			Lang.Nl,
			Lang.No,
			Lang.Pt,
			Lang.Sk,
			Lang.Sl,
			Lang.Sq,
			Lang.Sv,
			Lang.Tt,
			Lang.Hr,
			Lang.Hy
		};

		public Predictor(string predictorKey, string baseUrl = "https://predictor.yandex.net/api/v1/predict")
		{
			_key = predictorKey;
			_client = new RestClient(baseUrl);
		}

		public Lang[] GetLanguages()
		{
			RestRequest request = new RestRequest("getLangs");
			request.AddParameter("key", _key);

			RestResponse response = (RestResponse)_client.Execute(request);
			XmlAttributeDeserializer deserializer = new XmlAttributeDeserializer();
			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				var strs = deserializer.Deserialize<List<string>>(response);
				var allLangs = (Lang[])Enum.GetValues(typeof(Lang));
				Lang[] result = allLangs.Where(lang => strs.Contains(lang.ToString().ToLowerInvariant())).ToArray();
				return result;
			}

			var error = deserializer.Deserialize<YandexError>(response);
			throw new YandexLinguisticsException(error);
		}

		public CompleteResponse Complete(Lang lang, string q, int limit = 1)
		{
			RestRequest request = new RestRequest("complete");
			request.AddParameter("key", _key);
			request.AddParameter("lang", lang.ToString().ToLowerInvariant());
			request.AddParameter("q", q);
			request.AddParameter("limit", limit);

			RestResponse response = (RestResponse)_client.Execute(request);
			XmlAttributeDeserializer deserializer = new XmlAttributeDeserializer();
			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				var completeResponse = deserializer.Deserialize<CompleteResponse>(response);
				return completeResponse;
			}

			if (response.StatusCode != 0)
			{
				var error = deserializer.Deserialize<YandexError>(response);
				throw new YandexLinguisticsException(error);
			}

			throw new YandexLinguisticsException(0, response.ErrorMessage);
		}
	}
}
