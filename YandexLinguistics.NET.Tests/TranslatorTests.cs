using System;
using NUnit.Framework;
using YandexLinguistics.NET.Translator;

namespace YandexLinguistics.NET.Tests
{
	[TestFixture]
	public class TranslatorTests
	{
		private TranslatorService _translatorService;

		[OneTimeSetUp]
		public void Init()
		{
			_translatorService = new TranslatorService(Utils.TranslatorKey);
		}

		[Test]
		public void TranslatorGetLangs()
		{
			var expectedLangPairs = _translatorService.GetLanguagesAsync().Result;
			CollectionAssert.AreEquivalent(expectedLangPairs, TranslatorDirection.Pairs);
		}

		[Test]
		public void TranslatorDetectLang()
		{
			var lang = _translatorService.DetectLanguageAsync("Язик до Києва доведе").Result;
			Assert.AreEqual(Language.Uk, lang);
		}

		[Test]
		public void TranslatorTranslate()
		{
			var translation = _translatorService.TranslateAsync("Лучше поздно, чем никогда",
				TranslatorDirection.GetLangPair(Language.En, Language.Ru)).Result;
			Assert.AreEqual("Лучше поздно, чем никогда", translation.Texts[0]);
			Assert.AreEqual(TranslatorDirection.GetLangPair(Language.En, Language.Ru), translation.LanguagePair);
		}

		[Test]
		public void TranslatorDetectAndTranslate()
		{
			var translation = _translatorService.TranslateAsync("Семь раз отмерь, один раз отрежь",
				new LanguagePair(Language.None, Language.En), null, true).Result;
			Assert.AreEqual("Measure twice, cut once", translation.Texts[0]);
			Assert.AreEqual(TranslatorDirection.GetLangPair(Language.Ru, Language.En), translation.LanguagePair);
			Assert.AreEqual(Language.Ru, translation.DetectedLanguage.Language);
		}

		[Test]
		public void TranslatorLangNotSupported()
		{
			Translation translation;
			var exception = Assert.Throws<AggregateException>(
				() => translation = _translatorService.TranslateAsync("Example text", new LanguagePair(Language.None, Language.None)).Result);
			Assert.AreEqual(
				new YandexLinguisticsException(502, "Invalid parameter: lang").ToString(),
				exception.InnerException?.ToString());
		}

		[Test]
		public void TranslatorVeryLongInputString()
		{
			Translation translation;
			var exception = Assert.Throws<AggregateException>(
				() => translation = _translatorService.TranslateAsync(new string('a', 100000), new LanguagePair(Language.None, Language.Ru)).Result);
			Assert.AreEqual(
				new YandexLinguisticsException(0, "Invalid URI: The Uri string is too long.").ToString(),
				exception.InnerException?.ToString());
		}
	}
}