using System.Text.Json.Serialization;

namespace YandexLinguistics.NET
{
	public class YandexError
	{
		[JsonPropertyName("code")]
		public int Code { get; set; }

		[JsonPropertyName("message")]
		public string Message { get; set; }

		public override string ToString() => $"Code: {Code}; Message: {Message}";
	}
}
