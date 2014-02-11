using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET.Tests
{
	[TestFixture]
	public class PredictorTests
	{
		Predictor Predictor;

		[SetUp]
		public void Init()
		{
			Predictor = new Predictor(ConfigurationManager.AppSettings["PredictorKey"]);
		}

		[Test]
		public void PredictorGetLangs()
		{
			var langs = Predictor.GetLangs();
			var expectedLangs = new Lang[]
			{
				Lang.Ru,
				Lang.En,
				Lang.Pl,
				Lang.Uk,
				Lang.De,
				Lang.Fr,
				Lang.Es,
				Lang.It,
				Lang.Tr
			};

			Assert.IsTrue(expectedLangs.All(lang => langs.Contains(lang)));
		}

		[Test]
		public void PredictorComplete1()
		{
			var response = Predictor.Complete(Lang.En, "hello wo");

			Assert.AreEqual(-2, response.Pos);
			Assert.IsFalse(response.EndOfWord);
			Assert.AreEqual("world", response.Text[0]);
		}

		[Test]
		public void PredictorComplete2()
		{
			var response = Predictor.Complete(Lang.Ru, "здравствуй");

			Assert.AreEqual(-10, response.Pos);
			Assert.IsTrue(response.EndOfWord);
			Assert.AreEqual("здравствуйте", response.Text[0]);
		}

		[Test]
		public void PredictorWrongKey()
		{
			var predictor = new Predictor("1111");
			var exception = Assert.Throws<YandexLinguisticsException>(() => predictor.GetLangs());
			Assert.AreEqual(
				new YandexLinguisticsException(401, "API key is invalid").ToString(),
				exception.ToString());
		}

		[Test]
		public void PredictorVeryLongInputString()
		{
			var exception = Assert.Throws<YandexLinguisticsException>(
				() => Predictor.Complete(Lang.En, new string('a', 100000)));
			Assert.AreEqual(
				new YandexLinguisticsException(0, "Invalid URI: The Uri string is too long.").ToString(),
				exception.ToString());
		}
	}
}
