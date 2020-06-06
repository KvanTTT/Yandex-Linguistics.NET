using RestSharp.Deserializers;

namespace YandexLinguistics.NET
{
	public class Syn
	{
		[DeserializeAs(Attribute = false)]
		public string Text
		{
			get;
			set;
		}

		public Syn()
		{
		}
	}
}
