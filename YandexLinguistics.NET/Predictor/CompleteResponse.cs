using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace YandexLinguistics.NET.Predictor
{
	public class CompleteResponse
	{
		[JsonPropertyName("endOfWord")]
		public bool EndOfWord { get; set; }

		[JsonPropertyName("pos")]
		public int Position { get; set; }

		[JsonPropertyName("text")]
		public IReadOnlyList<string> Texts { get; set; }

		public override string ToString()
		{
			var result = new StringBuilder();

			result.Append("EndOfWord: ");
			result.AppendLine(EndOfWord.ToString());
			result.Append("Position: ");
			result.AppendLine(Position.ToString());
			result.Append("Texts: ");
			result.AppendLine(string.Join(",", Texts));

			return result.ToString();
		}
	}
}
