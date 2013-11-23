using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET
{
	public class Mean
	{
		[DeserializeAs(Attribute = false)]
		public string Text
		{
			get;
			set;
		}

		public Mean()
		{
		}
	}
}
