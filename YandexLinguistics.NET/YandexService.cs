using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace YandexLinguistics.NET
{
	public abstract class YandexService : IDisposable
	{
		private readonly HttpClient _httpClient;

		private readonly string _key;

		protected YandexService(string key, string baseUrl)
		{
			_key = key;
			_httpClient = new HttpClient {BaseAddress = new Uri(baseUrl + (baseUrl.EndsWith("/") ? "" : "/"))};
		}

		protected StringBuilder CreateRequestBuilder(string resource)
		{
			var result = new StringBuilder(resource);
			result.Append('?');
			if (!string.IsNullOrEmpty(_key))
			{
				result.Append("key=");
				result.Append(_key);
			}
			return result;
		}

		protected void AddParameter(StringBuilder request, string key, string value)
		{
			request.Append('&');
			request.Append(key);
			request.Append('=');
			request.Append(HttpUtility.UrlEncode(value));
		}

		protected async Task<T> GetAndDeserializeAsync<T>(StringBuilder request, CancellationToken cancellationToken = default)
		{
			HttpResponseMessage response = null;

			try
			{
				response = await _httpClient.GetAsync(request.ToString(), cancellationToken).ConfigureAwait(false);
				var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

				if (response.IsSuccessStatusCode)
				{
					return JsonSerializer.Deserialize<T>(result);
				}

				var error = JsonSerializer.Deserialize<YandexError>(result);
				throw new YandexLinguisticsException(error);
			}
			catch (Exception ex) when (!(ex is YandexLinguisticsException))
			{
				var errorMessage = !string.IsNullOrEmpty(response?.ReasonPhrase)
					? response.ReasonPhrase
					: ex.Message;
				throw new YandexLinguisticsException(response != null ? (int)response.StatusCode : 0, errorMessage);
			}
			finally
			{
				response?.Dispose();
			}
		}

		public void Dispose()
		{
			_httpClient?.Dispose();
		}
	}
}
