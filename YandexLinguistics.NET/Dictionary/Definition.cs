using RestSharp.Deserializers;
using System.Collections.Generic;
using System.Text;

namespace YandexLinguistics.NET
{
	public class Def
	{
		[DeserializeAs(Attribute = false)]
		public string Text
		{
			get;
			set;
		}

		[DeserializeAs(Name = "pos")]
		public string PartOfSpeech
		{
			get;
			set;
		}

		[DeserializeAs(Name = "ts")]
		public string Transcription
		{
			get;
			set;
		}

		public List<Tr> Translations
		{
			get;
			set;
		}

		public Def()
		{
		}

		public void ToString(StringBuilder builder, bool formatting, string indent)
		{
			if (!string.IsNullOrEmpty(PartOfSpeech))
				builder.Append("PartOfSpeech: " + PartOfSpeech);
			if (!string.IsNullOrEmpty(Transcription))
				builder.Append("; Transcription: " + Transcription);
			builder.AppendLine();
			foreach (var tr in Translations)
				tr.ToString(builder, 1, formatting, indent);
		}
	}
}
