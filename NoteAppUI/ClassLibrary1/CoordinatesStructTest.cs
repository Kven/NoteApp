using NUnit.Framework;
using System;


namespace NoteApp.UnitTests
{
	class CoordinatesStructTest
	{
		private Coordinates _coordinates;

		[SetUp]
		public void InitCoordinates()
		{
			_coordinates = new Coordinates(55, 55);
		}


		[TestCase(40, "Должно возникать исключение если значение меньше 50", TestName = "Присвоение значение меньше 50 в поле Х")]
		[TestCase(250, "Должно возникать исключение если значение больше 240", TestName = "Присвоение значение больше 240 в поле Х")]
		public void TestXCoordinatesStructSet_ArgumentExeption(int wrongValue, string message)
		{
			Assert.Throws<ArgumentException>(() => { var coordinates = new Coordinates(wrongValue, 50); }, message);
		}

		[TestCase(40, "Должно возникать исключение если значение меньше 50", TestName = "Присвоение значение меньше 50 в поле Y")]
		[TestCase(260, "Должно возникать исключение если значение больше 250", TestName = "Присвоение значение больше 250 в поле Y")]
		public void TestYCoordinatesStructSet_ArgumentExeption(int wrongValue, string message)
		{
			Assert.Throws<ArgumentException>(() => { var coordinates = new Coordinates(50, wrongValue); }, message);
		}


		[Test(Description = "Тестирование на получение значения из координаты X")]
		public void TestXCoordinatesStructGet_CorrentValue()
		{
			int expected = 55;

			Assert.AreEqual(_coordinates.X, expected, "Поле Х не возвращает значение");
		}

		[Test(Description = "Тестирование на получение значения из координаты У")]
		public void TestYCoordinatesStructGet_CorrentValue()
		{
			int expected = 55;

			Assert.AreEqual(_coordinates.Y, expected, "Поле У не возвращает значение");
		}
		
	}
}
