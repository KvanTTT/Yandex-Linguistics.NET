using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET
{
	public class DicResult
	{
		[DeserializeAs(Name = "pos")]
		public string PartOfSpeech
		{
			get;
			set;
		}

		public List<Def> Definitions
		{
			get;
			set;
		}

		public DicResult()
		{
		}
	}
}
