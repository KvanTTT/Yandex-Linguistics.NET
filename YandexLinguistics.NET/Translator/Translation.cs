using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YandexLinguistics.NET.Translator
{
	public class Translation
	{
		[JsonPropertyName("code")] public int Code { get; set; }

		[JsonPropertyName("lang")] public string LangPairString { get; set; }

		[JsonPropertyName("text")] public IReadOnlyList<string> Texts { get; set; }

		[JsonPropertyName("detected")] public DetectedLanguage DetectedLanguage { get; set; }

		public LanguagePair LanguagePair
		{
			get => LanguagePair.Parse(LangPairString);
			set => LangPairString = value.ToString().ToLowerInvariant();
		}
	}
}
