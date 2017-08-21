using NUnit.Framework;
using System.Configuration;
using System.Linq;

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
			LangPair[] expectedLangPairs = Dictionary.GetLangs();
			var langPairs = typeof(DictionaryDirectory).GetFields()
				.Where(field => field.FieldType == typeof(LangPair))
				.Select(field => (LangPair)field.GetValue(null));

			CollectionAssert.AreEquivalent(expectedLangPairs, langPairs);
		}

		[Test]
		public void DictionaryLookup()
		{
			var dicResult = Dictionary.Lookup(DictionaryDirectory.EnRu, "time");

			var def0 = dicResult.Definitions[0];
			var def1 = dicResult.Definitions[1];

			Assert.AreEqual("time", def0.Text);
			Assert.AreEqual(6, def0.Translations.Count);
			var tr = def0.Translations[0];
			Assert.AreEqual("noun", tr.PartOfSpeech);
			Assert.AreEqual("время", tr.Text);

			Assert.AreEqual("раз", tr.Synonyms[0].Text);
			Assert.AreEqual("момент", tr.Synonyms[1].Text);

			Assert.AreEqual("period", tr.Meanings[0].Text);
			Assert.AreEqual("once", tr.Meanings[1].Text);
			Assert.AreEqual("moment", tr.Meanings[2].Text);
			Assert.AreEqual("pore", tr.Meanings[3].Text);

			Assert.AreEqual("daylight saving time", tr.Examples[0].Text);
			Assert.AreEqual("летнее время", tr.Examples[0].Translations[0].Text);
			Assert.AreEqual("take some time", tr.Examples[1].Text);
			Assert.AreEqual("занять некоторое время", tr.Examples[1].Translations[0].Text);
			Assert.AreEqual("real time mode", tr.Examples[2].Text);
			Assert.AreEqual("режим реального времени", tr.Examples[2].Translations[0].Text);

			Assert.AreEqual("verb", def1.PartOfSpeech);
			Assert.AreEqual("taɪm", def1.Transcription);
			Assert.AreEqual("time", def1.Text);
			Assert.AreEqual("verb", def1.Translations[0].PartOfSpeech);
			Assert.AreEqual("приурочивать", def1.Translations[0].Text);
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

		[Test]
		public void DictionaryVeryLongInputString()
		{
			var exception = Assert.Throws<YandexLinguisticsException>(
				() => Dictionary.Lookup(DictionaryDirectory.EnRu, new string('a', 100000)));
			Assert.AreEqual(
				new YandexLinguisticsException(0, "Invalid URI: The Uri string is too long.").ToString(),
				exception.ToString());
		}
	}
}
