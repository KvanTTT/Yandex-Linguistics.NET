using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace YandexLinguistics.NET.Dictionary
{
	public class Translation
	{
		[JsonPropertyName("text")] public string Text { get; set; }

		[JsonPropertyName("pos")] public string PartOfSpeech { get; set; }

		[JsonPropertyName("syn")] public IReadOnlyList<Synonym> Synonyms { get; set; }

		[JsonPropertyName("mean")] public IReadOnlyList<Meaning> Meanings { get; set; }

		[JsonPropertyName("ex")] public IReadOnlyList<Example> Examples { get; set; }

		public void ToString(StringBuilder builder, int level, bool formatting, string indent)
		{
			for (int i = 0; i < level; i++)
				builder.Append(indent);
			builder.Append("Translation: " + Text);
			if (!string.IsNullOrEmpty(PartOfSpeech))
				builder.Append("; PartOfSpeech: " + PartOfSpeech);
			builder.AppendLine();

			if (Synonyms?.Count > 0)
			{
				for (int i = 0; i < level + 1; i++)
					builder.Append(indent);
				builder.Append("Synonyms: ");
				for (int i = 0; i < Synonyms.Count; i++)
				{
					builder.Append(Synonyms[i].Text);
					builder.Append(i == Synonyms.Count - 1 ? "." : ", ");
				}
				builder.AppendLine();
			}

			if (Meanings?.Count > 0)
			{
				for (int i = 0; i < level + 1; i++)
					builder.Append(indent);
				builder.Append("Meanings: ");
				for (int i = 0; i < Meanings.Count; i++)
				{
					builder.Append(Meanings[i].Text);
					builder.Append(i == Meanings.Count - 1 ? "." : ", ");
				}
				builder.AppendLine();
			}

			if (Examples?.Count > 0)
			{
				for (int i = 0; i < level + 1; i++)
					builder.Append(indent);
				builder.Append("Examples: ");
				builder.AppendLine();
				for (int i = 0; i < Examples.Count; i++)
					Examples[i].ToString(builder, level, formatting, indent);
			}
		}
	}
}
