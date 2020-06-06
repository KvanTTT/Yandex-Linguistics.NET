using RestSharp.Deserializers;

namespace YandexLinguistics.NET
{
	public class Error
	{
		public int Code { get; set; }

		[DeserializeAs(Name = "pos")] public int Position { get; set; }

		public int Row { get; set; }

		[DeserializeAs(Name = "col")] public int Column { get; set; }

		[DeserializeAs(Name = "len")] public int Length { get; set; }

		[DeserializeAs(Attribute = false)] public string Word { get; set; }

		[DeserializeAs(Attribute = false, Name = "s")]
		public string Steer { get; set; }

		public Error()
		{
		}
	}
}
