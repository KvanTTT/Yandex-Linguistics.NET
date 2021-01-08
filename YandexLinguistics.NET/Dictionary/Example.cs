using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace YandexLinguistics.NET.Dictionary
{
	public class Example
	{
		[JsonPropertyName("text")] public string Text { get; set; }

		[JsonPropertyName("tr")] public IReadOnlyList<Translation> Translations { get; set; }

		public void ToString(StringBuilder builder, int level, bool formatting, string indent)
		{
			for (int i = 0; i < level; i++)
				builder.Append(indent);

			if (Translations?.Count > 0)
				foreach (var translation in Translations)
					translation.ToString(builder, level + 1, formatting, indent);
		}
	}
}
