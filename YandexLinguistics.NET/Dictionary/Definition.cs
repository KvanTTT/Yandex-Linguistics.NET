using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace YandexLinguistics.NET.Dictionary
{
	public class Definition
	{
		[JsonPropertyName("text")] public string Text { get; set; }

		[JsonPropertyName("pos")] public string PartOfSpeech { get; set; }

		[JsonPropertyName("ts")] public string Transcription { get; set; }

		[JsonPropertyName("tr")] public IReadOnlyList<Translation> Translations { get; set; }

		public void ToString(StringBuilder builder, bool formatting, string indent)
		{
			if (!string.IsNullOrEmpty(PartOfSpeech))
				builder.Append("PartOfSpeech: " + PartOfSpeech);

			if (!string.IsNullOrEmpty(Transcription))
				builder.Append("; Transcription: " + Transcription);

			builder.AppendLine();

			foreach (var translation in Translations)
				translation.ToString(builder, 1, formatting, indent);
		}
	}
}
