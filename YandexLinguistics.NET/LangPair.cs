using System;

namespace YandexLinguistics.NET
{
	public readonly struct LangPair : IEquatable<LangPair>
	{
		public readonly Lang InputLang;
		public readonly Lang OutputLang;

		public LangPair(Lang inputLang, Lang outputLang)
		{
			InputLang = inputLang;
			OutputLang = outputLang;
		}

		public static LangPair Parse(string langPair)
		{
			var inOut = langPair.Split('-');
			var result = new LangPair((Lang)Enum.Parse(typeof(Lang), inOut[0], true),
									  (Lang)Enum.Parse(typeof(Lang), inOut[1], true));
			return result;
		}

		public override string ToString() => InputLang + "-" + OutputLang;

		public bool Equals(LangPair other)
		{
			return InputLang == other.InputLang && OutputLang == other.OutputLang;
		}

		public override bool Equals(object obj)
		{
			return obj is LangPair other && Equals(other);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return ((int) InputLang * 397) ^ (int) OutputLang;
			}
		}
	}
}
