using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace NoteApp.UnitTests
{
	[TestFixture]
	public class ChordTest

	{
		[Test(Description = "Тестирование присвоения значения в поле _name")]
		public void TestNameSet_CorrectValue()
		{
			var expected = "Am";
			var chord = new Chord();
			chord.Name = "Am";

			Assert.AreEqual(expected, chord.Name, "Set _name присваивает некорректное значение");
		}

		[Test(Description = "Тестирование на получение значения из поля _name")]
		public void TestNameGet_CorrectValue()
		{
			var expected = "Bm";
			var chord = new Chord();
			chord.Name = expected;
			var actual = chord.Name;

			Assert.AreEqual(expected, actual, "Get _name возвращает неверное значение");
		}

		[Test(Description = "Тестирование на присвоеие значения в поле begin")]
		public void TestBeginSet_CorrectValue()
		{
			var expected = 1;
			var chord = new Chord();
			chord.Begin = 1;

			Assert.AreEqual(expected, chord.Begin, "Set _begin присваивает некорректное значение");
		}

		[Test(Description = "Тестирование на получение значения из поля begin")]
		public void TestBeginGet_CorrectValue()
		{
			var expected = 7;
			var chord = new Chord();
			chord.Begin = expected;
			var actual = chord.Begin;

			Assert.AreEqual(expected, actual, "Get _begin возвращает неверное значение");
		}

		[Test(Description ="Тестирование присвоения значения в поле ")]
	}
}
