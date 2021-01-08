using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace YandexLinguistics.NET.Dictionary
{
	public class DictionaryResult
	{
		[JsonPropertyName("def")]
		public IReadOnlyList<Definition> Definitions { get; set; }

		public override string ToString() => ToString(false, "    ");

		public string ToString(bool formatting, string indent)
		{
			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < Definitions.Count; i++)
			{
				builder.Append(i + 1);
				builder.Append(". ");
				Definitions[i].ToString(builder, formatting, indent);
			}

			return builder.ToString();
		}
	}
}
