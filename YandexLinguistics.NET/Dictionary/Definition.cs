using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
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
	}
}
