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
			var response = Speller.CheckText("asdf@asdf.com орапгн36 москва", null, SpellerOptions.IgnoreDigits | SpellerOptions.IgnoreUrls | SpellerOptions.IgnoreCapitalization);

			Assert.AreEqual(0, response.Errors.Count);
		}

		[Test]
		public void SpellerSubstitution()
		{
			var mistakes = Speller.DamerauLevenshteinDistance("синхрАфазАтрон", "синхрофазотрон");
			Assert.AreEqual(2, mistakes.Count);
			Assert.AreEqual(mistakes[0].Position, 5);
			Assert.AreEqual(mistakes[0].Type, CharMistakeType.Substitution);
			Assert.AreEqual(mistakes[1].Position, 9);
			Assert.AreEqual(mistakes[1].Type, CharMistakeType.Substitution);
		}

		[Test]
		public void SpellerInsertion()
		{
			var mistakes = Speller.DamerauLevenshteinDistance("синхрофазотр", "синхрофазотрон");
			Assert.AreEqual(2, mistakes.Count);
			Assert.AreEqual(12, mistakes[0].Position);
			Assert.AreEqual(CharMistakeType.Insertion, mistakes[0].Type);
			Assert.AreEqual(13, mistakes[1].Position);
			Assert.AreEqual(CharMistakeType.Insertion, mistakes[1].Type);
		}

		[Test]
		public void SpellerDeletion1()
		{
			var mistakes = Speller.DamerauLevenshteinDistance("синНхрофаАзотрон", "синхрофазотрон");
			Assert.AreEqual(2, mistakes.Count);
			Assert.AreEqual(3, mistakes[0].Position);
			Assert.AreEqual(CharMistakeType.Deletion, mistakes[0].Type);
			Assert.AreEqual(8, mistakes[1].Position);
			Assert.AreEqual(CharMistakeType.Deletion, mistakes[1].Type);
		}

		[Test]
		public void SpellerDeletion2()
		{
			var mistakes = Speller.DamerauLevenshteinDistance("аДубна", "Дубна");
			Assert.AreEqual(1, mistakes.Count);
			Assert.AreEqual(0, mistakes[0].Position);
			Assert.AreEqual(CharMistakeType.Deletion, mistakes[0].Type);
		}

		[Test]
		public void SpellerTransposition()
		{
			var mistakes = Speller.DamerauLevenshteinDistance("синхрофазортон", "синхрофазотрон");
			Assert.AreEqual(1, mistakes.Count);
			Assert.AreEqual(10, mistakes[0].Position);
			Assert.AreEqual(CharMistakeType.Transposition, mistakes[0].Type);
		}

		[Test]
		public void SpellerTranspositionOff()
		{
			var mistakes = Speller.DamerauLevenshteinDistance("синхрофазортон", "синхрофазотрон", false);
			Assert.AreEqual(2, mistakes.Count);
			Assert.AreEqual(10, mistakes[0].Position);
			Assert.AreEqual(CharMistakeType.Insertion, mistakes[0].Type);
			Assert.AreEqual(12, mistakes[1].Position);
			Assert.AreEqual(CharMistakeType.Deletion, mistakes[1].Type);
		}

		[Test]
		public void SpellerMixed()
		{
			var mistakes = Speller.DamerauLevenshteinDistance("АсИнхрофаортон", "синхрофазотрон");
			Assert.AreEqual(4, mistakes.Count);
			Assert.AreEqual(0, mistakes[0].Position);
			Assert.AreEqual(CharMistakeType.Deletion, mistakes[0].Type);
			Assert.AreEqual(1, mistakes[1].Position);
			Assert.AreEqual(CharMistakeType.Substitution, mistakes[1].Type);
			Assert.AreEqual(8, mistakes[2].Position);
			Assert.AreEqual(CharMistakeType.Insertion, mistakes[2].Type);
			Assert.AreEqual(10, mistakes[3].Position);
			Assert.AreEqual(CharMistakeType.Transposition, mistakes[3].Type);
		}

		[Test]
		public void SpellerInputEpmty()
		{
			var mistakes = Speller.DamerauLevenshteinDistance("", "синхрофазотрон");
			Assert.AreEqual("синхрофазартон".Length, mistakes.Count);
			for (int i = 0; i < mistakes.Count; i++)
			{
				Assert.AreEqual(i, mistakes[i].Position);
				Assert.AreEqual(CharMistakeType.Insertion, mistakes[i].Type);
			}
		}

		[Test]
		public void SpellerOutputEpmty()
		{
			var mistakes = Speller.DamerauLevenshteinDistance("синхрофазотрон", "");
			Assert.AreEqual("синхрофазартон".Length, mistakes.Count);
			for (int i = 0; i < mistakes.Count; i++)
			{
				Assert.AreEqual(0, mistakes[i].Position);
				Assert.AreEqual(CharMistakeType.Deletion, mistakes[i].Type);
			}
		}
	}
}
