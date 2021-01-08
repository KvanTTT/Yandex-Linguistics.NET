using System.Text.Json.Serialization;

namespace YandexLinguistics.NET.Dictionary
{
	public class Synonym
	{
		[JsonPropertyName("text")] public string Text { get; set; }

		public override string ToString() => $"Synonym: {Text}";
	}
}
