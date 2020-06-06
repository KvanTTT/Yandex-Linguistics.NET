using RestSharp.Deserializers;

namespace YandexLinguistics.NET
{
	public class Translation
	{
		public int Code { get; set; }

		[DeserializeAs(Name = "lang")] public string LangPairString { get; set; }

		public LangPair LangPair
		{
			get => LangPair.Parse(LangPairString);
			set => LangPairString = value.ToString().ToLowerInvariant();
		}

		public DetectedLang Detected { get; set; }

		[DeserializeAs(Attribute = false)] public string Text { get; set; }
	}
}
