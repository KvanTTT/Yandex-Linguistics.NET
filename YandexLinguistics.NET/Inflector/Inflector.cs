using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET
{
	public class Inflector
	{
		protected RestClient _client;

		public Inflector(string baseUrl = "http://export.yandex.ru/inflect.xml")
		{
			_client = new RestClient(baseUrl);
		}

		public List<Inflection> GetInflections(string text)
		{
			RestRequest request = new RestRequest();
			request.AddParameter("name", text);

			RestResponse response = (RestResponse)_client.Execute(request);
			XmlAttributeDeserializer deserializer = new XmlAttributeDeserializer();
			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				var inflections = deserializer.Deserialize<List<Inflection>>(response);
				return inflections;
			}
			else
			{
				var error = deserializer.Deserialize<YandexError>(response);
				throw new YandexLinguisticsException(error);
			}
		}
	}
}
