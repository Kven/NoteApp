using System;
using System.Collections.Generic;
using NUnit.Framework;
using NoteApp;

namespace NoteApp.UnitTests
{
	[TestFixture]
	public class ChordTest
	{
		[Test(Description = "Положительный тест присвоения корректного значения в поле Name")]
		public void TestNameSet_CorrectValue()
		{
			var expected = "Am";
			var chord = new Chord();
			chord.Name = "Am";

			Assert.AreEqual(expected, chord.Name, "Set Name присваивает некорректное значение");
		}

	    [Test(Description = "Негативный тест присвоения некорректного значения в поле Name")]
	    public void TestNameSet_Longer10Symbols()
	    {
	        var wrongName = "Am10Sdasd5555131";
	        var chord = new Chord();

	        Assert.Throws<ArgumentException>(() => { chord.Name = wrongName; }, "Должно возникать исключение, если название больше 10 символов");
	    }

        [Test(Description = "Позитивный тест на получение значения из поля Name")]
		public void TestNameGet_CorrectValue()
		{
			var expected = "Bm";
			var chord = new Chord();
			chord.Name = expected;
			var actual = chord.Name;

			Assert.AreEqual(expected, actual, "Get Name возвращает неверное значение");
		}

		[Test(Description = "Позитивный тест на присвоение корректного значения в поле BeginFret")]
		public void TestBeginFretSet_CorrectValue()
		{
			var expected = 1;
			var chord = new Chord();
			chord.BeginFret = 1;

			Assert.AreEqual(expected, chord.BeginFret, "Set BeginFret присваивает некорректное значение");
		}

		[Test(Description = "Негативный тест на присвоение некорректного значения в поле BeginFret")]
		public void TestBeginFretSet_Bigger12Value()
		{
			var wrongBeginFret = 13;
			var chord = new Chord();

			Assert.Throws<ArgumentException>(() => { chord.BeginFret = wrongBeginFret; }, "Должно возникать исключение " +
				"если начальный лад больше 12");
		}

		[Test(Description = "Тестирование на получение значения из поля BeginFret")]
		public void TestBeginFretGet_CorrectValue()
		{
			var expected = 7;
			var chord = new Chord();
			chord.BeginFret = expected;
			var actual = chord.BeginFret;

			Assert.AreEqual(expected, actual, "Get BeginFret возвращает неверное значение");
		}

		[Test(Description = "Тестирование на получение значения из поля Points")]
		public void TestPointsGet_CorrectValue()
		{
			var expected = new List<Coordinates> { new Coordinates(50,50)};
			var chord = new Chord();
			chord.AddPoint(new Coordinates(50,50));
			var actual = chord.Points;

			Assert.AreEqual(expected, actual, "Get Points возвращает неверное значение");
		}

		[Test(Description = "Тестирование на присвоение значения в поле Points")]
		public void TestPointsSet_CorrectValue()
		{
			var expected = new List<Coordinates> { new Coordinates(50, 50) };
			var chord = new Chord();
			chord.Points = expected;
			var actual = chord.Points;

			Assert.AreEqual(expected, actual, "Get Points возвращает неверное значение");
		}

		[Test(Description = "Тестирование метода на добавления значения в список поля Points")]
		public void TestAddPoint_Method()
		{
			var expected = new Coordinates(50,50);
			var chord = new Chord();
			chord.AddPoint(new Coordinates(50,50));

			Assert.AreEqual(expected, chord.Points[0], "AddPoint присваивает некорректное значение");
		}

		[Test(Description = "Тестирование конструктора с начальным названием")]
		public void TestChordStringAndInt_Construct()
		{
			string expectedName = "Am";
			int expectedBegin = 1;
			var chord = new Chord("Am",1);

			Assert.AreEqual(expectedName, chord.Name, "Конструктор присваивает некорректное значение в название");
			Assert.AreEqual(expectedBegin, chord.BeginFret, "Конструктор присваивает некорректное значение в начальный лад");
			Assert.IsEmpty(chord.Points, "Не инициализировался список точек");

		}

		[Test(Description = "Тестирование пустого конструктора")]
		public void TestChord_Construct()
		{
			var chord = new Chord();

			Assert.Zero(chord.BeginFret, "Конструктор присвоил какое-то значение в поле BeginFret");
			Assert.IsNull(chord.Name, "Конструктор присвоил какое-то значение в поле Name");
			Assert.IsEmpty(chord.Points, "Конструктор присвоил какое-то значение в поле Points");
		}
	}
}
