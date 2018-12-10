using System.Collections.Generic;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
	[TestFixture]
	public class ChordTest

	{
		[Test(Description = "Тестирование присвоения значения в поле Name")]
		public void TestNameSet_CorrectValue()
		{
			var expected = "Am";
			var chord = new Chord();
			chord.Name = "Am";

			Assert.AreEqual(expected, chord.Name, "Set Name присваивает некорректное значение");
		}

		[Test(Description = "Тестирование на получение значения из поля Name")]
		public void TestNameGet_CorrectValue()
		{
			var expected = "Bm";
			var chord = new Chord();
			chord.Name = expected;
			var actual = chord.Name;

			Assert.AreEqual(expected, actual, "Get Name возвращает неверное значение");
		}

		[Test(Description = "Тестирование на присвоеие значения в поле BeginFret")]
		public void TestBeginSet_CorrectValue()
		{
			var expected = 1;
			var chord = new Chord();
			chord.BeginFret = 1;

			Assert.AreEqual(expected, chord.BeginFret, "Set BeginFret присваивает некорректное значение");
		}

		[Test(Description = "Тестирование на получение значения из поля BeginFret")]
		public void TestBeginGet_CorrectValue()
		{
			var expected = 7;
			var chord = new Chord();
			chord.BeginFret = expected;
			var actual = chord.BeginFret;

			Assert.AreEqual(expected, actual, "Get BeginFret возвращает неверное значение");
		}

		[Test(Description = "Тестирование на получение значения из поля frets")]
		public void TestFretsGet_CorrectValue()
		{
			var expected = (1,1);
			var chord = new Chord();
			//chord.AddPoint(expected);
			var actual = chord.Points;

			Assert.AreEqual(expected, actual, "Get Points возвращает неверное значение");
		}

		[Test(Description = "Тестирование метода на добавления значения в список поля frets")]
		public void TestSetFretsCoor_Method()
		{
			var expected = (1, 1);
			var chord = new Chord();
		//	chord.AddPoint((1,1));

			Assert.AreEqual(expected, chord.Points[0], "AddPoint присваивает некорректное значение");
		}

		[Test(Description = "Тестирование конструктора с начальным названием")]
		public void TestChordString_Construct()
		{
			string expectedName = "Am";
			int expectedBegin = 1;
			var chord = new Chord("Am",1);

			Assert.AreEqual(expectedName, chord.Name, "Конструктор присваивает некорректное значение в название");
			Assert.AreEqual(expectedBegin, chord.BeginFret, "Конструктор присваивает некорректное значение в начальный лад");

		}

		[Test(Description = "Тестирование пустого конструктора")]
		public void TestChord_Construct()
		{
			
			var chord = new Chord();

			Assert.IsNull(chord.Name, "Конструктор присваивает какое то значение");
		}
	}
}
