using System;

namespace YandexLinguistics.NET
{
	public readonly struct LangPair
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
	}
}
