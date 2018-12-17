using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
	public class ListOfChordsTest
	{
		private ListOfChords _expected;
		private ListOfChords _actual;

		[SetUp]
		public void InitListOfChords()
		{
			_expected = new ListOfChords();
			_expected.Chords.Add(new Chord("Am", 1));

			_actual = new ListOfChords();
		}

		[Test(Description = "Проверка возвращаемого значения из поля Chords")]
		public void TestGetChords_CurrentValue()
		{
			_actual.Chords.Add(new Chord("Am", 1));

			Assert.AreEqual(_expected.Chords[0].Name, _actual.Chords[0].Name, "Возвращается не верное значение");
			Assert.AreEqual(_expected.Chords[0].BeginFret, _actual.Chords[0].BeginFret, "Возвращается не верное значение");
		}

		[Test(Description = "Проверка присвоения значения в поле Chords")]
		public void TestSetChords_CurrentValue()
		{
			_actual = _expected;

			Assert.AreEqual(_expected.Chords[0].Name, _actual.Chords[0].Name, "Возвращается не верное значение");
			Assert.AreEqual(_expected.Chords[0].BeginFret, _actual.Chords[0].BeginFret, "Возвращается не верное значение");
		}

		[Test(Description = "Проверка конструктора без параметров")]
		public void TestListOfChords_Construstor()
		{
			Assert.IsEmpty(_actual.Chords, "Конструктор что-то присваивает");
		}

		[Test(Description = "Проверка индексатора")]
		public void TestIndexer()
		{
			_actual.Chords.Add(new Chord("Am", 1));
			var actualChord = _actual[0];

			Assert.AreEqual(_actual.Chords[0].Name, actualChord.Name, "Индексатор не работает как полагается");
		}



	}
}
