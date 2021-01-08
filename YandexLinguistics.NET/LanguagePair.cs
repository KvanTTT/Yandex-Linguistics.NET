using System;

namespace YandexLinguistics.NET
{
	public readonly struct LanguagePair : IEquatable<LanguagePair>
	{
		public readonly Language InputLanguage;
		public readonly Language OutputLanguage;

		public LanguagePair(Language inputLanguage, Language outputLanguage)
		{
			InputLanguage = inputLanguage;
			OutputLanguage = outputLanguage;
		}

		public static LanguagePair Parse(string langPair)
		{
			var inOut = langPair.Split('-');
			var result = new LanguagePair((Language)Enum.Parse(typeof(Language), inOut[0], true),
									  (Language)Enum.Parse(typeof(Language), inOut[1], true));
			return result;
		}

		public override string ToString() => InputLanguage + "-" + OutputLanguage;

		public bool Equals(LanguagePair other)
		{
			return InputLanguage == other.InputLanguage && OutputLanguage == other.OutputLanguage;
		}

		public override bool Equals(object obj)
		{
			return obj is LanguagePair other && Equals(other);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return ((int) InputLanguage * 397) ^ (int) OutputLanguage;
			}
		}
	}
}
