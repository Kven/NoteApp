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
			var expected = new List<Chord>();
			//expected.Add(new Chord() { Name = "Am", Begin = 1, Frets = new List<Tuple<int,int>>{ (1, 1) });
			string path = "C:/test.txt";
			Serializator.SaveFile(expected, path);
			var actual = new List<Chord>();
			
			using (StreamReader file = File.OpenText(path))
			{
				JsonSerializer serializer = new JsonSerializer();
				actual = (List<Chord>)serializer.Deserialize(file, typeof(List<Chord>));
			}

		    foreach (var variable in expected)
		    {
		        foreach (var actualvar in actual)
		        {
		            Assert.AreEqual(variable.Name, actualvar.Name, "Файл сериализован не правильно");
		        }
		    }
			
		}

		[Test(Description = "Тест метода десириализации из файла")]
		public void TestJsonLoadFile_Method()
		{

		}
	}
}
