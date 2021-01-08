using System.Text.Json.Serialization;

namespace YandexLinguistics.NET.Translator
{
	public class DetectedLanguage
	{
		[JsonPropertyName("lang")] public Language Language { get; set; }
	}
}
