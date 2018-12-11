using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using NUnit.Framework;
using System;

namespace NoteApp.UnitTests
{
	[TestFixture]
	class JsonTest
	{
		[Test(Description = "Тест метода сериализации в файл")]
		public void TestJsonSaveFile_Method()
		{
			var expected = new ListOfChords();
			expected.Chords.Add(new Chord() { Name = "Am", BeginFret = 1 });
			string path = "d:/test.txt";
			Serialize.SaveFile(expected, path);
			var actual = new ListOfChords();
			
			using (StreamReader file = File.OpenText(path))
			{
				JsonSerializer serializer = new JsonSerializer();
				actual = (ListOfChords)serializer.Deserialize(file, typeof(ListOfChords));
			}

		    foreach (var variable in expected.Chords)
		    {
		        foreach (var actualVar in actual.Chords)
		        {
		            Assert.AreEqual(variable.Name, actualVar.Name, "Файл сериализован не правильно");
		        }
		    }
			
		}

		[Test(Description = "Тест метода десириализации из файла")]
		public void TestJsonLoadFile_Method()
		{

		}
	}
}
