using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET
{
	public class CompleteResponse
	{
		public bool EndOfWord
		{
			get;
			set;
		}

		public int Pos
		{
			get;
			set;
		}

		public List<string> Text
		{
			get;
			set;
		}

		public CompleteResponse()
		{
		}
	}
}
