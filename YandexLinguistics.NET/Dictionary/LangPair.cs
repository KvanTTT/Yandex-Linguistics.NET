using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET
{
	public struct LangPair
	{
		public Lang InputLang;
		public Lang OutputLang;

		public static readonly LangPair RuRu = new LangPair(Lang.Ru, Lang.Ru);
		public static readonly LangPair RuEn = new LangPair(Lang.Ru, Lang.En);
		public static readonly LangPair RuPl = new LangPair(Lang.Ru, Lang.Pl);
		public static readonly LangPair RuUk = new LangPair(Lang.Ru, Lang.Uk);
		public static readonly LangPair RuDe = new LangPair(Lang.Ru, Lang.De);
		public static readonly LangPair RuFr = new LangPair(Lang.Ru, Lang.Fr);
		public static readonly LangPair RuEs = new LangPair(Lang.Ru, Lang.Es);
		public static readonly LangPair RuIt = new LangPair(Lang.Ru, Lang.It);
		public static readonly LangPair RuTr = new LangPair(Lang.Ru, Lang.Tr);
		public static readonly LangPair EnRu = new LangPair(Lang.En, Lang.Ru);
		public static readonly LangPair EnEn = new LangPair(Lang.En, Lang.En);
		public static readonly LangPair EnDe = new LangPair(Lang.En, Lang.De);
		public static readonly LangPair EnFr = new LangPair(Lang.En, Lang.Fr);
		public static readonly LangPair EnEs = new LangPair(Lang.En, Lang.Es);
		public static readonly LangPair EnIt = new LangPair(Lang.En, Lang.It);
		public static readonly LangPair EnTr = new LangPair(Lang.En, Lang.Tr);
		public static readonly LangPair PlRu = new LangPair(Lang.Pl, Lang.Ru);
		public static readonly LangPair UkRu = new LangPair(Lang.Uk, Lang.Ru);
		public static readonly LangPair DeRu = new LangPair(Lang.De, Lang.Ru);
		public static readonly LangPair DeEn = new LangPair(Lang.De, Lang.En);
		public static readonly LangPair FrRu = new LangPair(Lang.Fr, Lang.Ru);
		public static readonly LangPair FrEn = new LangPair(Lang.Fr, Lang.En);
		public static readonly LangPair EsRu = new LangPair(Lang.Es, Lang.Ru);
		public static readonly LangPair EsEn = new LangPair(Lang.Es, Lang.En);
		public static readonly LangPair ItRu = new LangPair(Lang.It, Lang.Ru);
		public static readonly LangPair ItEn = new LangPair(Lang.It, Lang.En);
		public static readonly LangPair TrRu = new LangPair(Lang.Tr, Lang.Ru);
		public static readonly LangPair TrEn = new LangPair(Lang.Tr, Lang.En);

		public LangPair(Lang inputLang, Lang outputLang)
		{
			InputLang = inputLang;
			OutputLang = outputLang;
		}

		public override string ToString()
		{
			return InputLang.ToString().ToLowerInvariant() + "-" + OutputLang.ToString().ToLowerInvariant();
		}
	}
}
