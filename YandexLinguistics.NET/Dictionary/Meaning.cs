using System.Text.Json.Serialization;

namespace YandexLinguistics.NET.Dictionary
{
	public class Meaning
	{
		[JsonPropertyName("text")] public string Text { get; set; }

		public override string ToString() => $"Meaning: {Text}";
	}
}
