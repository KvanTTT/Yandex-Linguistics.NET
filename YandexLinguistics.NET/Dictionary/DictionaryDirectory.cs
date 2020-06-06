using System.Collections.Generic;

namespace YandexLinguistics.NET
{
	public static class DictionaryDirectory
	{
		public static readonly IReadOnlyCollection<LangPair> Pairs = new []
		{
			new LangPair(Lang.Be, Lang.Be),
			new LangPair(Lang.Be, Lang.Ru),
			new LangPair(Lang.Bg, Lang.Ru),
			new LangPair(Lang.Cs, Lang.Cs),
			new LangPair(Lang.Cs, Lang.En),
			new LangPair(Lang.Cs, Lang.Ru),
			new LangPair(Lang.Da, Lang.En),
			new LangPair(Lang.Da, Lang.Ru),
			new LangPair(Lang.De, Lang.De),
			new LangPair(Lang.De, Lang.En),
			new LangPair(Lang.De, Lang.Ru),
			new LangPair(Lang.De, Lang.Tr),
			new LangPair(Lang.El, Lang.En),
			new LangPair(Lang.El, Lang.Ru),
			new LangPair(Lang.En, Lang.Cs),
			new LangPair(Lang.En, Lang.Da),
			new LangPair(Lang.En, Lang.De),
			new LangPair(Lang.En, Lang.El),
			new LangPair(Lang.En, Lang.En),
			new LangPair(Lang.En, Lang.Es),
			new LangPair(Lang.En, Lang.Et),
			new LangPair(Lang.En, Lang.Fi),
			new LangPair(Lang.En, Lang.Fr),
			new LangPair(Lang.En, Lang.It),
			new LangPair(Lang.En, Lang.Lt),
			new LangPair(Lang.En, Lang.Lv),
			new LangPair(Lang.En, Lang.Nl),
			new LangPair(Lang.En, Lang.No),
			new LangPair(Lang.En, Lang.Pt),
			new LangPair(Lang.En, Lang.Ru),
			new LangPair(Lang.En, Lang.Sk),
			new LangPair(Lang.En, Lang.Sv),
			new LangPair(Lang.En, Lang.Tr),
			new LangPair(Lang.En, Lang.Uk),
			new LangPair(Lang.Es, Lang.En),
			new LangPair(Lang.Es, Lang.Es),
			new LangPair(Lang.Es, Lang.Ru),
			new LangPair(Lang.Et, Lang.En),
			new LangPair(Lang.Et, Lang.Ru),
			new LangPair(Lang.Fi, Lang.En),
			new LangPair(Lang.Fi, Lang.Fi),
			new LangPair(Lang.Fi, Lang.Ru),
			new LangPair(Lang.Fr, Lang.En),
			new LangPair(Lang.Fr, Lang.Fr),
			new LangPair(Lang.Fr, Lang.Ru),
			new LangPair(Lang.Hu, Lang.Hu),
			new LangPair(Lang.Hu, Lang.Ru),
			new LangPair(Lang.It, Lang.En),
			new LangPair(Lang.It, Lang.It),
			new LangPair(Lang.It, Lang.Ru),
			new LangPair(Lang.Lt, Lang.En),
			new LangPair(Lang.Lt, Lang.Lt),
			new LangPair(Lang.Lt, Lang.Ru),
			new LangPair(Lang.Lv, Lang.En),
			new LangPair(Lang.Lv, Lang.Ru),
			new LangPair(Lang.Mhr, Lang.Ru),
			new LangPair(Lang.Mrj, Lang.Ru),
			new LangPair(Lang.Nl, Lang.En),
			new LangPair(Lang.Nl, Lang.Ru),
			new LangPair(Lang.No, Lang.En),
			new LangPair(Lang.No, Lang.Ru),
			new LangPair(Lang.Pl, Lang.Ru),
			new LangPair(Lang.Pt, Lang.En),
			new LangPair(Lang.Pt, Lang.Ru),
			new LangPair(Lang.Ru, Lang.Be),
			new LangPair(Lang.Ru, Lang.Bg),
			new LangPair(Lang.Ru, Lang.Cs),
			new LangPair(Lang.Ru, Lang.Da),
			new LangPair(Lang.Ru, Lang.De),
			new LangPair(Lang.Ru, Lang.El),
			new LangPair(Lang.Ru, Lang.En),
			new LangPair(Lang.Ru, Lang.Es),
			new LangPair(Lang.Ru, Lang.Et),
			new LangPair(Lang.Ru, Lang.Fi),
			new LangPair(Lang.Ru, Lang.Fr),
			new LangPair(Lang.Ru, Lang.Hu),
			new LangPair(Lang.Ru, Lang.It),
			new LangPair(Lang.Ru, Lang.Lt),
			new LangPair(Lang.Ru, Lang.Lv),
			new LangPair(Lang.Ru, Lang.Mhr),
			new LangPair(Lang.Ru, Lang.Mrj),
			new LangPair(Lang.Ru, Lang.Nl),
			new LangPair(Lang.Ru, Lang.No),
			new LangPair(Lang.Ru, Lang.Pl),
			new LangPair(Lang.Ru, Lang.Pt),
			new LangPair(Lang.Ru, Lang.Ru),
			new LangPair(Lang.Ru, Lang.Sk),
			new LangPair(Lang.Ru, Lang.Sv),
			new LangPair(Lang.Ru, Lang.Tr),
			new LangPair(Lang.Ru, Lang.Tt),
			new LangPair(Lang.Ru, Lang.Uk),
			new LangPair(Lang.Ru, Lang.Zh),
			new LangPair(Lang.Sk, Lang.En),
			new LangPair(Lang.Sk, Lang.Ru),
			new LangPair(Lang.Sv, Lang.En),
			new LangPair(Lang.Sv, Lang.Ru),
			new LangPair(Lang.Tr, Lang.De),
			new LangPair(Lang.Tr, Lang.En),
			new LangPair(Lang.Tr, Lang.Ru),
			new LangPair(Lang.Tt, Lang.Ru),
			new LangPair(Lang.Uk, Lang.En),
			new LangPair(Lang.Uk, Lang.Ru),
			new LangPair(Lang.Uk, Lang.Uk),
			new LangPair(Lang.Zh, Lang.Ru)
		};

		public static LangPair GetLangPair(Lang input, Lang output)
		{
			foreach (LangPair pair in Pairs)
			{
				if (pair.InputLang == input && pair.OutputLang == output)
				{
					return pair;
				}
			}

			throw new KeyNotFoundException($"Dictionary pair with input {input} and output {output} languages does not exist");
		}
	}
}
