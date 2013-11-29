using RestSharp;
using RestSharp.Deserializers;

namespace YandexLinguistics.NET
{
	public class Speller
	{
		protected RestClient _client = new RestClient("http://speller.yandex.net/services/spellservice");

		public Speller()
		{
		}

		public SpellResult CheckText(string text, Lang? lang = null, SpellerOptions? options = null, OutputFormat? format = null)
		{
			RestRequest request = new RestRequest("checkText");
			request.AddParameter("text", text);
			if (lang.HasValue)
				request.AddParameter("lang", lang.Value.ToString().ToLowerInvariant());
			if (options.HasValue)
				request.AddParameter("options", (int)options.Value);
			if (format.HasValue)
				request.AddParameter("format", format.Value.ToString().ToLowerInvariant());

			RestResponse response = (RestResponse)_client.Execute(request);
			XmlAttributeDeserializer deserializer = new XmlAttributeDeserializer();
			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				var spellResult = deserializer.Deserialize<SpellResult>(response);
				return spellResult;
			}
			else
			{
				var error = deserializer.Deserialize<YandexError>(response);
				throw new YandexLinguisticsException(error);
			}
		}

		public ArrayOfSpellResult CheckTexts(string[] texts, Lang? lang = null, SpellerOptions? options = null, OutputFormat? format = null)
		{
			RestRequest request = new RestRequest("checkTexts");
			foreach (var text in texts)
				request.AddParameter("text", text);
			if (lang.HasValue)
				request.AddParameter("lang", lang.Value.ToString().ToLowerInvariant());
			if (options.HasValue)
				request.AddParameter("options", (int)options.Value);
			if (format.HasValue)
				request.AddParameter("format", format.Value.ToString().ToLowerInvariant());

			RestResponse response = (RestResponse)_client.Execute(request);
			XmlAttributeDeserializer deserializer = new XmlAttributeDeserializer();
			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				var spellResult = deserializer.Deserialize<ArrayOfSpellResult>(response);
				return spellResult;
			}
			else
			{
				var error = deserializer.Deserialize<YandexError>(response);
				throw new YandexLinguisticsException(error);
			}
		}
	}
}
