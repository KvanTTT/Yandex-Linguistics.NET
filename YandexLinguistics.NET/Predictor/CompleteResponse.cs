using System.Collections.Generic;

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
