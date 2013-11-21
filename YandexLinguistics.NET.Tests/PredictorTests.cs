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
		string _predictorKey = ConfigurationManager.AppSettings["PredictorKey"];
		Predictor _predictor;

		[SetUp]
		public void Init()
		{
			_predictor = new Predictor(_predictorKey);
		}

		[Test]
		public void PredictorGetLangs()
		{
			var langs = _predictor.GetLangs();
			var allLangs = (Lang[])Enum.GetValues(typeof(Lang));

			Assert.IsTrue(allLangs.All(lang => langs.Contains(lang)));
		}

		[Test]
		public void Complete1()
		{
			var response = _predictor.Complete(Lang.En, "hello wo");

			Assert.AreEqual(-2, response.Pos);
			Assert.IsFalse(response.EndOfWord);
			Assert.AreEqual("world", response.Text[0]);
		}

		[Test]
		public void Complete2()
		{
			var response = _predictor.Complete(Lang.Ru, "здравствуй");

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
	}
}
