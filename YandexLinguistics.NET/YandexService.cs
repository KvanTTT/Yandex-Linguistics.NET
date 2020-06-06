using RestSharp;
using RestSharp.Serialization.Xml;

namespace YandexLinguistics.NET
{
	public abstract class YandexService
	{
		private readonly RestClient _client;
		protected readonly string _key;

		protected YandexService(string key, string baseUrl)
		{
			_key = key;
			_client = new RestClient(baseUrl);
		}

		protected T SendRequest<T>(RestRequest request)
		{
			RestResponse response = (RestResponse)_client.Execute(request);
			XmlAttributeDeserializer deserializer = new XmlAttributeDeserializer();
			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				var result = deserializer.Deserialize<T>(response);
				return result;
			}

			YandexError error = null;
			try
			{
				error = deserializer.Deserialize<YandexError>(response);
			}
			finally
			{
				if (error == null)
				{
					var errorMessage = !string.IsNullOrEmpty(response.ErrorMessage) ?
						response.ErrorMessage : response.Content;
					throw new YandexLinguisticsException((int)response.StatusCode, errorMessage);
				}

				throw new YandexLinguisticsException(error);
			}
		}
	}
}
