using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET.Tests
{
	[TestFixture]
	public class SpellerTests
	{
		Speller Speller;

		[SetUp]
		public void Init()
		{
			Speller = new Speller();
		}

		[Test]
		public void SpellerCheckText()
		{
			var spellResult = Speller.CheckText("синхрафазатрон в дубне");

			var error = spellResult.Errors[0];
			Assert.AreEqual(1, error.Code);
			Assert.AreEqual(0, error.Position);
			Assert.AreEqual(0, error.Row);
			Assert.AreEqual(0, error.Column);
			Assert.AreEqual(14, error.Length);
			Assert.AreEqual("синхрафазатрон", error.Word);
			Assert.AreEqual("синхрофазотрон", error.Steer);

			error = spellResult.Errors[1];
			Assert.AreEqual(3, error.Code);
			Assert.AreEqual(17, error.Position);
			Assert.AreEqual(0, error.Row);
			Assert.AreEqual(17, error.Column);
			Assert.AreEqual(5, error.Length);
			Assert.AreEqual("дубне", error.Word);
			Assert.AreEqual("Дубне", error.Steer);
		}

		[Test]
		public void SpellerCheckTexts()
		{
			var response = Speller.CheckTexts(new string[] { "синхрафазатрон", "в дубне" });

			var error = response.Results[0].Errors[0];
			Assert.AreEqual(1, error.Code);
			Assert.AreEqual(0, error.Position);
			Assert.AreEqual(0, error.Row);
			Assert.AreEqual(0, error.Column);
			Assert.AreEqual(14, error.Length);
			Assert.AreEqual("синхрафазатрон", error.Word);
			Assert.AreEqual("синхрофазотрон", error.Steer);

			error = response.Results[1].Errors[0];
			Assert.AreEqual(3, error.Code);
			Assert.AreEqual(2, error.Position);
			Assert.AreEqual(0, error.Row);
			Assert.AreEqual(2, error.Column);
			Assert.AreEqual(5, error.Length);
			Assert.AreEqual("дубне", error.Word);
			Assert.AreEqual("Дубне", error.Steer);
		}

		[Test]
		public void SpellerFlags()
		{
			var response = Speller.CheckText("asdf@asdf.com орапгн36 москва", Lang.Ru, SpellerOptions.IgnoreDigits | SpellerOptions.IgnoreUrls | SpellerOptions.IgnoreCapitalization);

			Assert.AreEqual(0, response.Errors.Count);
		}
	}
}
