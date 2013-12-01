using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET
{
	public struct Mistake
	{
		public int Position;
		public CharMistakeType Type;

		public Mistake(int position, CharMistakeType type)
		{
			Position = position;
			Type = type;
		}

		public override string ToString()
		{
			return Position + ", " + Type;
		}
	}
}
