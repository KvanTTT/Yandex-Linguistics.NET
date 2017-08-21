using NUnit.Framework;
using System.Configuration;
using System.Linq;

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
			var expectedLangs = Predictor.GetLangs();
			var langs = typeof(PredictorLang).GetFields()
				.Where(field => field.FieldType == typeof(Lang))
				.Select(field => (Lang)field.GetValue(null));

			CollectionAssert.AreEquivalent(expectedLangs, langs);
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
