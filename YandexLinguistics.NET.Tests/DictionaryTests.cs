using System;
using System.Collections.Generic;
using NUnit.Framework;
using YandexLinguistics.NET.Dictionary;

namespace YandexLinguistics.NET.Tests
{
	[TestFixture]
	public class DictionaryTests
	{
		private DictionaryService _dictionaryService;

		[OneTimeSetUp]
		public void Init()
		{
			_dictionaryService = new DictionaryService(Utils.DictionaryKey);
		}

		[Test]
		public void DictionaryGetLanguages()
		{
			IReadOnlyList<LanguagePair> expectedLangPairs = _dictionaryService.GetLanguagesAsync().Result;
			CollectionAssert.AreEquivalent(expectedLangPairs, DictionaryDirection.Pairs);
		}

		[Test]
		public void DictionaryLookup()
		{
			var dicResult = _dictionaryService.LookupAsync(DictionaryDirection.GetLanguagePair(Language.En, Language.Ru), "time").Result;

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
			Assert.AreEqual("now", tr.Meanings[3].Text);

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
			DictionaryResult result;
			var exception = Assert.Throws<AggregateException>(
				() => result = _dictionaryService.LookupAsync(new LanguagePair(Language.Uk, Language.It), "asdf").Result);
			Assert.AreEqual(
				new YandexLinguisticsException(501, "The specified language is not supported").ToString(),
				exception.InnerException?.ToString());
		}

		[Test]
		public void DictionaryVeryLongInputString()
		{
			DictionaryResult result;
			var exception = Assert.Throws<AggregateException>(
				() => result = _dictionaryService.LookupAsync(DictionaryDirection.GetLanguagePair(Language.En, Language.Ru), new string('a', 100000)).Result);
			Assert.AreEqual(
				new YandexLinguisticsException(0, "Invalid URI: The Uri string is too long.").ToString(),
				exception.InnerException?.ToString());
		}
	}
}
