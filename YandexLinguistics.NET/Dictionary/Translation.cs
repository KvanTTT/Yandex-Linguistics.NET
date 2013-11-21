using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET
{
	public class Tr
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

		public List<Syn> Synonyms
		{
			get;
			set;
		}

		public List<Mean> Meanings
		{
			get;
			set;
		}

		public List<Ex> Examples
		{
			get;
			set;
		}

		public Tr()
		{
		}
	}
}
