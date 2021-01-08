using System.Collections.Generic;

namespace YandexLinguistics.NET.Dictionary
{
	public static class DictionaryDirection
	{
		public static readonly IReadOnlyList<LanguagePair> Pairs = new []
		{
			new LanguagePair(Language.Be, Language.Be),
			new LanguagePair(Language.Be, Language.Ru),
			new LanguagePair(Language.Bg, Language.Ru),
			new LanguagePair(Language.Cs, Language.Cs),
			new LanguagePair(Language.Cs, Language.En),
			new LanguagePair(Language.Cs, Language.Ru),
			new LanguagePair(Language.Da, Language.En),
			new LanguagePair(Language.Da, Language.Ru),
			new LanguagePair(Language.De, Language.De),
			new LanguagePair(Language.De, Language.En),
			new LanguagePair(Language.De, Language.Ru),
			new LanguagePair(Language.De, Language.Tr),
			new LanguagePair(Language.El, Language.En),
			new LanguagePair(Language.El, Language.Ru),
			new LanguagePair(Language.En, Language.Cs),
			new LanguagePair(Language.En, Language.Da),
			new LanguagePair(Language.En, Language.De),
			new LanguagePair(Language.En, Language.El),
			new LanguagePair(Language.En, Language.En),
			new LanguagePair(Language.En, Language.Es),
			new LanguagePair(Language.En, Language.Et),
			new LanguagePair(Language.En, Language.Fi),
			new LanguagePair(Language.En, Language.Fr),
			new LanguagePair(Language.En, Language.It),
			new LanguagePair(Language.En, Language.Lt),
			new LanguagePair(Language.En, Language.Lv),
			new LanguagePair(Language.En, Language.Nl),
			new LanguagePair(Language.En, Language.No),
			new LanguagePair(Language.En, Language.Pt),
			new LanguagePair(Language.En, Language.Ru),
			new LanguagePair(Language.En, Language.Sk),
			new LanguagePair(Language.En, Language.Sv),
			new LanguagePair(Language.En, Language.Tr),
			new LanguagePair(Language.En, Language.Uk),
			new LanguagePair(Language.Es, Language.En),
			new LanguagePair(Language.Es, Language.Es),
			new LanguagePair(Language.Es, Language.Ru),
			new LanguagePair(Language.Et, Language.En),
			new LanguagePair(Language.Et, Language.Ru),
			new LanguagePair(Language.Fi, Language.En),
			new LanguagePair(Language.Fi, Language.Fi),
			new LanguagePair(Language.Fi, Language.Ru),
			new LanguagePair(Language.Fr, Language.En),
			new LanguagePair(Language.Fr, Language.Fr),
			new LanguagePair(Language.Fr, Language.Ru),
			new LanguagePair(Language.Hu, Language.Hu),
			new LanguagePair(Language.Hu, Language.Ru),
			new LanguagePair(Language.It, Language.En),
			new LanguagePair(Language.It, Language.It),
			new LanguagePair(Language.It, Language.Ru),
			new LanguagePair(Language.Lt, Language.En),
			new LanguagePair(Language.Lt, Language.Lt),
			new LanguagePair(Language.Lt, Language.Ru),
			new LanguagePair(Language.Lv, Language.En),
			new LanguagePair(Language.Lv, Language.Ru),
			new LanguagePair(Language.Mhr, Language.Ru),
			new LanguagePair(Language.Mrj, Language.Ru),
			new LanguagePair(Language.Nl, Language.En),
			new LanguagePair(Language.Nl, Language.Ru),
			new LanguagePair(Language.No, Language.En),
			new LanguagePair(Language.No, Language.Ru),
			new LanguagePair(Language.Pl, Language.Ru),
			new LanguagePair(Language.Pt, Language.En),
			new LanguagePair(Language.Pt, Language.Ru),
			new LanguagePair(Language.Ru, Language.Be),
			new LanguagePair(Language.Ru, Language.Bg),
			new LanguagePair(Language.Ru, Language.Cs),
			new LanguagePair(Language.Ru, Language.Da),
			new LanguagePair(Language.Ru, Language.De),
			new LanguagePair(Language.Ru, Language.El),
			new LanguagePair(Language.Ru, Language.En),
			new LanguagePair(Language.Ru, Language.Es),
			new LanguagePair(Language.Ru, Language.Et),
			new LanguagePair(Language.Ru, Language.Fi),
			new LanguagePair(Language.Ru, Language.Fr),
			new LanguagePair(Language.Ru, Language.Hu),
			new LanguagePair(Language.Ru, Language.It),
			new LanguagePair(Language.Ru, Language.Lt),
			new LanguagePair(Language.Ru, Language.Lv),
			new LanguagePair(Language.Ru, Language.Mhr),
			new LanguagePair(Language.Ru, Language.Mrj),
			new LanguagePair(Language.Ru, Language.Nl),
			new LanguagePair(Language.Ru, Language.No),
			new LanguagePair(Language.Ru, Language.Pl),
			new LanguagePair(Language.Ru, Language.Pt),
			new LanguagePair(Language.Ru, Language.Ru),
			new LanguagePair(Language.Ru, Language.Sk),
			new LanguagePair(Language.Ru, Language.Sv),
			new LanguagePair(Language.Ru, Language.Tr),
			new LanguagePair(Language.Ru, Language.Tt),
			new LanguagePair(Language.Ru, Language.Uk),
			new LanguagePair(Language.Ru, Language.Zh),
			new LanguagePair(Language.Sk, Language.En),
			new LanguagePair(Language.Sk, Language.Ru),
			new LanguagePair(Language.Sv, Language.En),
			new LanguagePair(Language.Sv, Language.Ru),
			new LanguagePair(Language.Tr, Language.De),
			new LanguagePair(Language.Tr, Language.En),
			new LanguagePair(Language.Tr, Language.Ru),
			new LanguagePair(Language.Tt, Language.Ru),
			new LanguagePair(Language.Uk, Language.En),
			new LanguagePair(Language.Uk, Language.Ru),
			new LanguagePair(Language.Uk, Language.Uk),
			new LanguagePair(Language.Zh, Language.Ru)
		};

		public static LanguagePair GetLanguagePair(Language input, Language output)
		{
			foreach (LanguagePair pair in Pairs)
			{
				if (pair.InputLanguage == input && pair.OutputLanguage == output)
				{
					return pair;
				}
			}

			throw new KeyNotFoundException($"Dictionary pair with input {input} and output {output} languages does not exist");
		}
	}
}
