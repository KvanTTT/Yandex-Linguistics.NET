using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET.Tests
{
	public class InflectorTests
	{
		Inflector Inflector;

		[SetUp]
		public void Init()
		{
			Inflector = new Inflector();
		}

		[Test]
		public void Inflect()
		{
			var inflections = Inflector.GetInflections("Вася Пупкин");
			Assert.AreEqual("Вася Пупкин", inflections[0].Value);
			Assert.AreEqual("Васи Пупкина", inflections[1].Value);
			Assert.AreEqual("Васе Пупкину", inflections[2].Value);
			Assert.AreEqual("Васю Пупкина", inflections[3].Value);
			Assert.AreEqual("Васей Пупкиным", inflections[4].Value);
			Assert.AreEqual("Васе Пупкине", inflections[5].Value);
		}
	}
}
