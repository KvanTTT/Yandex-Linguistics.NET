using System;
using System.Collections.Generic;
using NUnit.Framework;
using YandexLinguistics.NET.Speller;

namespace YandexLinguistics.NET.Tests
{
	[TestFixture]
	public class SpellerTests
	{
		private SpellerService _spellerService;

		[SetUp]
		public void Init()
		{
			_spellerService = new SpellerService();
		}

		[Test]
		public void SpellerCheckText()
		{
			var spellResult = _spellerService.CheckTextAsync("синхрафазатрон в дубне").Result;

			var error = spellResult[0];
			Assert.AreEqual(1, error.Code);
			Assert.AreEqual(0, error.Position);
			Assert.AreEqual(0, error.Row);
			Assert.AreEqual(0, error.Column);
			Assert.AreEqual(14, error.Length);
			Assert.AreEqual("синхрафазатрон", error.Word);
			Assert.AreEqual("синхрофазотрон", error.Steers[0]);

			error = spellResult[1];
			Assert.AreEqual(3, error.Code);
			Assert.AreEqual(17, error.Position);
			Assert.AreEqual(0, error.Row);
			Assert.AreEqual(17, error.Column);
			Assert.AreEqual(5, error.Length);
			Assert.AreEqual("дубне", error.Word);
			Assert.AreEqual("Дубне", error.Steers[0]);
		}

		[Test]
		public void SpellerCheckTexts()
		{
			var response = _spellerService.CheckTextsAsync(new[] { "синхрафазатрон", "в дубне" }).Result;

			var error = response[0][0];
			Assert.AreEqual(1, error.Code);
			Assert.AreEqual(0, error.Position);
			Assert.AreEqual(0, error.Row);
			Assert.AreEqual(0, error.Column);
			Assert.AreEqual(14, error.Length);
			Assert.AreEqual("синхрафазатрон", error.Word);
			Assert.AreEqual("синхрофазотрон", error.Steers[0]);

			error = response[1][0];
			Assert.AreEqual(3, error.Code);
			Assert.AreEqual(2, error.Position);
			Assert.AreEqual(0, error.Row);
			Assert.AreEqual(2, error.Column);
			Assert.AreEqual(5, error.Length);
			Assert.AreEqual("дубне", error.Word);
			Assert.AreEqual("Дубне", error.Steers[0]);
		}

		[Test]
		public void SpellerFlags()
		{
			var response = _spellerService.CheckTextAsync("asdf@asdf.com орапгн36 москва", null, SpellerOptions.IgnoreDigits | SpellerOptions.IgnoreUrls | SpellerOptions.IgnoreCapitalization).Result;

			Assert.AreEqual(0, response.Count);
		}

		[Test]
		public void SpellerSubstitution()
		{
			var mistakes = SpellerService.OptimalStringAlignmentDistance("синхрАфазАтрон", "синхрофазотрон");
			Assert.AreEqual(2, mistakes.Count);
			Assert.AreEqual(mistakes[0].Position, 5);
			Assert.AreEqual(mistakes[0].Type, CharMistakeType.Substitution);
			Assert.AreEqual(mistakes[1].Position, 9);
			Assert.AreEqual(mistakes[1].Type, CharMistakeType.Substitution);
		}

		[Test]
		public void SpellerInsertion()
		{
			var mistakes = SpellerService.OptimalStringAlignmentDistance("синхрофазотр", "синхрофазотрон");
			Assert.AreEqual(2, mistakes.Count);
			Assert.AreEqual(12, mistakes[0].Position);
			Assert.AreEqual(CharMistakeType.Insertion, mistakes[0].Type);
			Assert.AreEqual(13, mistakes[1].Position);
			Assert.AreEqual(CharMistakeType.Insertion, mistakes[1].Type);
		}

		[Test]
		public void SpellerDeletion1()
		{
			var mistakes = SpellerService.OptimalStringAlignmentDistance("синНхрофаАзотрон", "синхрофазотрон");
			Assert.AreEqual(2, mistakes.Count);
			Assert.AreEqual(3, mistakes[0].Position);
			Assert.AreEqual(CharMistakeType.Deletion, mistakes[0].Type);
			Assert.AreEqual(8, mistakes[1].Position);
			Assert.AreEqual(CharMistakeType.Deletion, mistakes[1].Type);
		}

		[Test]
		public void SpellerDeletion2()
		{
			var mistakes = SpellerService.OptimalStringAlignmentDistance("аДубна", "Дубна");
			Assert.AreEqual(1, mistakes.Count);
			Assert.AreEqual(0, mistakes[0].Position);
			Assert.AreEqual(CharMistakeType.Deletion, mistakes[0].Type);
		}

		[Test]
		public void SpellerTransposition()
		{
			var mistakes = SpellerService.OptimalStringAlignmentDistance("синхрофазортон", "синхрофазотрон");
			Assert.AreEqual(1, mistakes.Count);
			Assert.AreEqual(10, mistakes[0].Position);
			Assert.AreEqual(CharMistakeType.Transposition, mistakes[0].Type);
		}

		[Test]
		public void SpellerTranspositionOff()
		{
			var mistakes = SpellerService.OptimalStringAlignmentDistance("синхрофазортон", "синхрофазотрон", false);
			Assert.AreEqual(2, mistakes.Count);
			Assert.AreEqual(10, mistakes[0].Position);
			Assert.AreEqual(CharMistakeType.Insertion, mistakes[0].Type);
			Assert.AreEqual(12, mistakes[1].Position);
			Assert.AreEqual(CharMistakeType.Deletion, mistakes[1].Type);
		}

		[Test]
		public void SpellerMixed()
		{
			var mistakes = SpellerService.OptimalStringAlignmentDistance("АсИнхрофаортон", "синхрофазотрон");
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
		public void SpellerInputEmpty()
		{
			var mistakes = SpellerService.OptimalStringAlignmentDistance("", "синхрофазотрон");
			Assert.AreEqual("синхрофазартон".Length, mistakes.Count);
			for (int i = 0; i < mistakes.Count; i++)
			{
				Assert.AreEqual(i, mistakes[i].Position);
				Assert.AreEqual(CharMistakeType.Insertion, mistakes[i].Type);
			}
		}

		[Test]
		public void SpellerOutputEmpty()
		{
			var mistakes = SpellerService.OptimalStringAlignmentDistance("синхрофазотрон", "");
			Assert.AreEqual("синхрофазартон".Length, mistakes.Count);
			for (int i = 0; i < mistakes.Count; i++)
			{
				Assert.AreEqual(0, mistakes[i].Position);
				Assert.AreEqual(CharMistakeType.Deletion, mistakes[i].Type);
			}
		}

		[Test]
		public void SpellerVeryLongInputString()
		{
			IReadOnlyList<Error> errors;
			var exception = Assert.Throws<AggregateException>(
				() => errors = _spellerService.CheckTextAsync(new string('a', 100000)).Result);
			Assert.AreEqual(
				new YandexLinguisticsException(0, "Invalid URI: The Uri string is too long.").ToString(),
				exception.InnerException?.ToString());
		}
	}
}
