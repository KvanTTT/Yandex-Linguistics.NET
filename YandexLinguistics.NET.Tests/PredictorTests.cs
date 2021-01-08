using System;
using System.Collections.Generic;
using NUnit.Framework;
using YandexLinguistics.NET.Predictor;

namespace YandexLinguistics.NET.Tests
{
	[TestFixture]
	public class PredictorTests
	{
		private PredictorService _predictorService;

		[OneTimeSetUp]
		public void Init()
		{
			_predictorService = new PredictorService(Utils.PredictorKey);
		}

		[Test]
		public void PredictorGetLanguages()
		{
			var expectedLanguages = _predictorService.GetLanguagesAsync().Result;
			CollectionAssert.AreEquivalent(expectedLanguages, PredictorService.Languages);
		}

		[Test]
		public void PredictorComplete1()
		{
			var response = _predictorService.CompleteAsync(Language.En, "hello wo").Result;

			Assert.AreEqual(-2, response.Position);
			Assert.IsFalse(response.EndOfWord);
			Assert.AreEqual("world", response.Texts[0]);
		}

		[Test]
		public void PredictorComplete2()
		{
			var response = _predictorService.CompleteAsync(Language.Ru, "здравствуй").Result;

			Assert.AreEqual(-10, response.Position);
			Assert.IsTrue(response.EndOfWord);
			Assert.AreEqual("здравствуйте", response.Texts[0]);
		}

		[Test]
		public void PredictorWrongKey()
		{
			IReadOnlyList<Language> languages;
			var predictor = new PredictorService("1111");
			var exception = Assert.Throws<AggregateException>(() => languages = predictor.GetLanguagesAsync().Result);
			Assert.AreEqual(
				new YandexLinguisticsException(401, "API key is invalid").ToString(),
				exception.InnerException?.ToString());
		}

		[Test]
		public void PredictorVeryLongInputString()
		{
			CompleteResponse response;
			var exception = Assert.Throws<AggregateException>(
				() => response = _predictorService.CompleteAsync(Language.En, new string('a', 100000)).Result);
			Assert.AreEqual(
				new YandexLinguisticsException(0, "Invalid URI: The Uri string is too long.").ToString(),
				exception.InnerException?.ToString());
		}
	}
}
