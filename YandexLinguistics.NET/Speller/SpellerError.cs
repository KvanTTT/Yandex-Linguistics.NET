using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace YandexLinguistics.NET.Speller
{
	public class Error
	{
		[JsonPropertyName("code")] public int Code { get; set; }

		[JsonPropertyName("pos")] public int Position { get; set; }

		[JsonPropertyName("row")] public int Row { get; set; }

		[JsonPropertyName("col")] public int Column { get; set; }

		[JsonPropertyName("len")] public int Length { get; set; }

		[JsonPropertyName("word")] public string Word { get; set; }

		[JsonPropertyName("s")] public IReadOnlyList<string> Steers { get; set; }

		public override string ToString()
		{
			var result = new StringBuilder();
			result.Append("Code: ");
			result.AppendLine(Code.ToString());
			result.Append("Position: ");
			result.AppendLine(Position.ToString());
			result.Append("Row: ");
			result.AppendLine(Row.ToString());
			result.Append("Column: ");
			result.AppendLine(Column.ToString());
			result.Append("Length: ");
			result.AppendLine(Length.ToString());
			result.Append("Word: ");
			result.AppendLine(Word);
			result.Append("Steers: ");
			result.AppendLine(string.Join(",", Steers));
			return result.ToString();
		}
	}
}
