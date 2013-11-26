using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET.Tests
{
	[TestFixture]
	public class DictionaryTests
	{
		Dictionary Dictionary;

		[SetUp]
		public void Init()
		{
			Dictionary = new Dictionary(ConfigurationManager.AppSettings["DictionaryKey"]);
		}

		[Test]
		public void DictionaryGetLangs()
		{
			var langPairs = Dictionary.GetLangs();
			var expectedLangPairs = new List<LangPair>()
			{
				LangPair.RuRu,
				LangPair.RuEn,
				LangPair.RuPl,
				LangPair.RuUk,
				LangPair.RuDe,
				LangPair.RuFr,
				LangPair.RuEs,
				LangPair.RuIt,
				LangPair.RuTr,
				LangPair.EnRu,
				LangPair.EnEn,
				LangPair.EnDe,
				LangPair.EnFr,
				LangPair.EnEs,
				LangPair.EnIt,
				LangPair.EnTr,
				LangPair.PlRu,
				LangPair.UkRu,
				LangPair.DeRu,
				LangPair.DeEn,
				LangPair.FrRu,
				LangPair.FrEn,
				LangPair.EsRu,
				LangPair.EsEn,
				LangPair.ItRu,
				LangPair.ItEn,
				LangPair.TrRu,
				LangPair.TrEn,
			};

			Assert.IsTrue(expectedLangPairs.All(lang => langPairs.Contains(lang)));
		}

		[Test]
		public void DictionaryLookup()
		{
			var dicResult = Dictionary.Lookup(LangPair.EnRu, "time");

			var def0 = dicResult.Definitions[0];
			var def1 = dicResult.Definitions[1];

			Assert.AreEqual("time", def0.Text);
			Assert.AreEqual(1, def0.Translations.Count);
			var tr = def0.Translations[0];
			Assert.AreEqual("существительное", tr.PartOfSpeech);
			Assert.AreEqual("время", tr.Text);

			Assert.AreEqual("раз", tr.Synonyms[0].Text);
			Assert.AreEqual("тайм", tr.Synonyms[1].Text);

			Assert.AreEqual("timing", tr.Meanings[0].Text);
			Assert.AreEqual("fold", tr.Meanings[1].Text);
			Assert.AreEqual("half", tr.Meanings[2].Text);

			Assert.AreEqual("thromboplastin time", tr.Examples[0].Text);
			Assert.AreEqual("тромбопластиновое время", tr.Examples[0].Translations[0].Text);
			Assert.AreEqual("umpteenth time", tr.Examples[1].Text);
			Assert.AreEqual("энный раз", tr.Examples[1].Translations[0].Text);
			Assert.AreEqual("second time", tr.Examples[2].Text);
			Assert.AreEqual("второй тайм", tr.Examples[2].Translations[0].Text);

			Assert.AreEqual("adverbial participle", def1.PartOfSpeech);
			Assert.AreEqual("taɪm", def1.Transcription);
			Assert.AreEqual("time", def1.Text);
			Assert.AreEqual("деепричастие", def1.Translations[0].PartOfSpeech);
			Assert.AreEqual("временя", def1.Translations[0].Text);
		}

		[Test]
		public void DictionaryLangNotSupported()
		{
			var exception = Assert.Throws<YandexLinguisticsException>(
				() => Dictionary.Lookup(new LangPair(Lang.Uk, Lang.It), "asdf"));
			Assert.AreEqual(
				new YandexLinguisticsException(501, "The specified language is not supported").ToString(),
				exception.ToString());
		}
	}
}
