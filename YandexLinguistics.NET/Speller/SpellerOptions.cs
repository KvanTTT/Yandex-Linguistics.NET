using System;

namespace YandexLinguistics.NET
{
	[Flags]
	public enum SpellerOptions
	{
		IgnoreUppercase = 1,
		IgnoreDigits = 2,
		IgnoreUrls = 4,
		FindRepeatWords = 8,
		IgnoreLatin = 16,
		NoSuggest = 32,
		FlagLatin = 128,
		ByWords = 256,
		IgnoreCapitalization = 512
	}
}
