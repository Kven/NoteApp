using System.Collections.Generic;
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

		[Test(Description = "Тестирование на присвоеие значения в поле frets")]
		public void TestFretsSet_CorrectValue()
		{
			var expected = new List<int[]> { new int[] { 1, 1 } };
			var chord = new Chord();
			chord.Frets = new List<int[]> { new int[] { 1, 1 } };

			Assert.AreEqual(expected, chord.Frets, "Set _frets присваивает некорректное значение");
		}

		[Test(Description = "Тестирование на получение значения из поля frets")]
		public void TestFretsGet_CorrectValue()
		{
			var expected = new List<int[]> { new int[] { 1, 1 } };
			var chord = new Chord();
			chord.Frets = expected;
			var actual = chord.Frets;

			Assert.AreEqual(expected, actual, "Get _frets возвращает неверное значение");
		}

		[Test(Description = "Тестирование метода на добавления значения в список поля frets")]
		public void TestSetFretsCoor_Method()
		{
			var expected = new int[] { 1, 1 };
			var chord = new Chord();
			chord.SetFretsCoor(new int[] { 1, 1 });

			Assert.AreEqual(expected, chord.Frets[0], "SetFretsCoor присваивает некорректное значение");
		}

		[Test(Description = "Тестирование конструктора с начальным названием")]
		public void TestChordString_Construct()
		{
			string expected = "Am";
			var chord = new Chord("Am");

			Assert.AreEqual(expected, chord.Name, "Конструктор присваивает некорректное значение в название");
		}

		[Test(Description = "Тестирование пустого конструктора")]
		public void TestChord_Construct()
		{
			
			var chord = new Chord();

			Assert.IsNull(chord.Name, "Конструктор присваивает какое то значение");
		}
	}
}
