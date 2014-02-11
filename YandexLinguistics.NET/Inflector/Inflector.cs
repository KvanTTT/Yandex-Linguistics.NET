using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET
{
	public class Inflector : YandexService
	{
		public Inflector(string baseUrl = "http://export.yandex.ru/inflect.xml")
			: base("", baseUrl)
		{
		}

		public List<Inflection> GetInflections(string text)
		{
			RestRequest request = new RestRequest();
			request.AddParameter("name", text);

			return SendRequest<List<Inflection>>(request);
		}
	}
}
