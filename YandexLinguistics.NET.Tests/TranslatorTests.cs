using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET.Tests
{
	[TestFixture]
	public class TranslatorTests
	{
		Translator Translator;

		[SetUp]
		public void Init()
		{
			Translator = new Translator(ConfigurationManager.AppSettings["TranslatorKey"]);
		}

		[Test]
		public void TranslatorGetLangs()
		{
			var langPairs = Translator.GetLangs();

			var expectedLangPairs = new LangPair[]
			{
				LangPair.AzRu,
				LangPair.BeBg,
				LangPair.BeCs,
				LangPair.BeDe,
				LangPair.BeEn,
				LangPair.BeEs,
				LangPair.BeFr,
				LangPair.BeIt,
				LangPair.BePl,
				LangPair.BeRo,
				LangPair.BeRu,
				LangPair.BeSr,
				LangPair.BeTr,
				LangPair.BgBe,
				LangPair.BgRu,
				LangPair.BgUk,
				LangPair.CaEn,
				LangPair.CaRu,
				LangPair.CsBe,
				LangPair.CsEn,
				LangPair.CsRu,
				LangPair.CsUk,
				LangPair.DaEn,
				LangPair.DaRu,
				LangPair.DeBe,
				LangPair.DeEn,
				LangPair.DeEs,
				LangPair.DeFr,
				LangPair.DeIt,
				LangPair.DeRu,
				LangPair.DeTr,
				LangPair.DeUk,
				LangPair.ElEn,
				LangPair.ElRu,
				LangPair.EnBe,
				LangPair.EnCa,
				LangPair.EnCs,
				LangPair.EnDa,
				LangPair.EnDe,
				LangPair.EnEl,
				LangPair.EnEs,
				LangPair.EnEt,
				LangPair.EnFi,
				LangPair.EnFr,
				LangPair.EnHu,
				LangPair.EnIt,
				LangPair.EnLt,
				LangPair.EnLv,
				LangPair.EnMk,
				LangPair.EnNl,
				LangPair.EnNo,
				LangPair.EnPt,
				LangPair.EnRu,
				LangPair.EnSk,
				LangPair.EnSl,
				LangPair.EnSq,
				LangPair.EnSv,
				LangPair.EnTr,
				LangPair.EnUk,
				LangPair.EsBe,
				LangPair.EsDe,
				LangPair.EsEn,
				LangPair.EsRu,
				LangPair.EsUk,
				LangPair.EtEn,
				LangPair.EtRu,
				LangPair.FiEn,
				LangPair.FiRu,
				LangPair.FrBe,
				LangPair.FrDe,
				LangPair.FrEn,
				LangPair.FrRu,
				LangPair.FrUk,
				LangPair.HrRu,
				LangPair.HuEn,
				LangPair.HuRu,
				LangPair.HyRu,
				LangPair.ItBe,
				LangPair.ItDe,
				LangPair.ItEn,
				LangPair.ItRu,
				LangPair.ItUk,
				LangPair.LtEn,
				LangPair.LtRu,
				LangPair.LvEn,
				LangPair.LvRu,
				LangPair.MkEn,
				LangPair.MkRu,
				LangPair.NlEn,
				LangPair.NlRu,
				LangPair.NoEn,
				LangPair.NoRu,
				LangPair.PlBe,
				LangPair.PlRu,
				LangPair.PlUk,
				LangPair.PtEn,
				LangPair.PtRu,
				LangPair.RoBe,
				LangPair.RoRu,
				LangPair.RoUk,
				LangPair.RuAz,
				LangPair.RuBe,
				LangPair.RuBg,
				LangPair.RuCa,
				LangPair.RuCs,
				LangPair.RuDa,
				LangPair.RuDe,
				LangPair.RuEl,
				LangPair.RuEn,
				LangPair.RuEs,
				LangPair.RuEt,
				LangPair.RuFi,
				LangPair.RuFr,
				LangPair.RuHr,
				LangPair.RuHu,
				LangPair.RuHy,
				LangPair.RuIt,
				LangPair.RuLt,
				LangPair.RuLv,
				LangPair.RuMk,
				LangPair.RuNl,
				LangPair.RuNo,
				LangPair.RuPl,
				LangPair.RuPt,
				LangPair.RuRo,
				LangPair.RuSk,
				LangPair.RuSl,
				LangPair.RuSq,
				LangPair.RuSr,
				LangPair.RuSv,
				LangPair.RuTr,
				LangPair.RuUk,
				LangPair.SkEn,
				LangPair.SkRu,
				LangPair.SlEn,
				LangPair.SlRu,
				LangPair.SqEn,
				LangPair.SqRu,
				LangPair.SrBe,
				LangPair.SrRu,
				LangPair.SrUk,
				LangPair.SvEn,
				LangPair.SvRu,
				LangPair.TrBe,
				LangPair.TrDe,
				LangPair.TrEn,
				LangPair.TrRu,
				LangPair.TrUk,
				LangPair.UkBg,
				LangPair.UkCs,
				LangPair.UkDe,
				LangPair.UkEn,
				LangPair.UkEs,
				LangPair.UkFr,
				LangPair.UkIt,
				LangPair.UkPl,
				LangPair.UkRo,
				LangPair.UkRu,
				LangPair.UkSr,
				LangPair.UkTr,
			};

			Assert.IsTrue(expectedLangPairs.All(lang => langPairs.Contains(lang)));
		}

		[Test]
		public void TranslatorDetectLang()
		{
			var lang = Translator.DetectLang("Язик до Києва доведе");
			Assert.AreEqual(Lang.Uk, lang);
		}

		[Test]
		public void TranslatorTranslate()
		{
			var translation = Translator.Translate("Лучше поздно, чем никогда", LangPair.EnRu);
			Assert.AreEqual("Лучше поздно, чем никогда", translation.Text);
			Assert.AreEqual(LangPair.EnRu, translation.LangPair);
		}

		[Test]
		public void TranslatorDetectAndTranslate()
		{
			var translation = Translator.Translate("Семь раз отмерь, один раз отрежь", new LangPair(Lang.None, Lang.En), null, true);
			Assert.AreEqual("Seven times, cut once", translation.Text);
			Assert.AreEqual(LangPair.RuEn, translation.LangPair);
			Assert.AreEqual(Lang.Ru, translation.Detected.Lang);
		}

		[Test]
		public void TranslatorLangNotSupported()
		{
			var exception = Assert.Throws<YandexLinguisticsException>(
				() => Translator.Translate("Example text", new LangPair(Lang.None, Lang.None)));
			Assert.AreEqual(
				new YandexLinguisticsException(501, "The specified translation direction is not supported").ToString(),
				exception.ToString());
		}
	}
}