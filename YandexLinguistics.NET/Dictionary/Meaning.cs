using RestSharp.Deserializers;

namespace YandexLinguistics.NET
{
	public class Mean
	{
		[DeserializeAs(Attribute = false)] public string Text { get; set; }

		public Mean()
		{
		}
	}
}
