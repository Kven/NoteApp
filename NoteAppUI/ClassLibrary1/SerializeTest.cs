using System.IO;
using Newtonsoft.Json;
using NUnit.Framework;
using System;

namespace NoteApp.UnitTests
{
	[TestFixture]
	public class SerializeTest
	{
		[Test(Description = "Тест метода сериализации в файл")]
		public void TestSerializeSaveFile_Method()
		{
			var expected = new ListOfChords();
			expected.Chords.Add(new Chord() { Name = "Am", BeginFret = 1 });
			string path = AppDomain.CurrentDomain.BaseDirectory + @"\Test.txt";
			Serialize.SaveFile(expected, path);
			var actual = new ListOfChords();
			
			using (StreamReader file = File.OpenText(path))
			{
				JsonSerializer serializer = new JsonSerializer();
				actual = (ListOfChords)serializer.Deserialize(file, typeof(ListOfChords));
			}

		    foreach (var expectedVariable in expected.Chords)
		    {
		        foreach (var actualVariable in actual.Chords)
		        {
		            Assert.AreEqual(expectedVariable.Name, actualVariable.Name, "Файл сериализован не правильно");
					Assert.AreEqual(expectedVariable.BeginFret, actualVariable.BeginFret, "Файл сериализован не правильно");
				}
		    }
		}

		[Test(Description = "Тест метода десириализации из файла")]
		public void TestSerializeLoadFile_Method()
		{
			var expected = new ListOfChords();
			expected.Chords.Add(new Chord("Am", 1));
			string path = AppDomain.CurrentDomain.BaseDirectory + @"\Test.txt";
			Serialize.SaveFile(expected, path);
			var actual = Serialize.ReadFile(path);

			foreach (var expectedVariable in expected.Chords)
			{
				foreach (var actualVariable in actual.Chords)
				{
					Assert.AreEqual(expectedVariable.Name, actualVariable.Name, "Файл дессиарилизован не верно");
					Assert.AreEqual(expectedVariable.BeginFret, actualVariable.BeginFret, "Файл дессиарилизован не верно");
				}

			}
		}
	}
}
