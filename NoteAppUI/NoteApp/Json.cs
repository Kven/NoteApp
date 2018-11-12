using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    public static class Json
    {
		/// <summary>
		/// Метод для сохранения списка в файл
		/// </summary>
		/// <param name="data">Список, который нужно сохранить</param>
        public static void SaveFile(List<Chord> data, string path)
        {
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }

		/// <summary>
		/// Метод для считывания файла и импорта из него значений в список
		/// </summary>
		/// <returns>Список аккордов, которые сохранены в файле</returns>
        public static List<Chord> ReadFile(string path)
        {
            List<Chord> data = null;
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Chord> temp = (List<Chord>)serializer.Deserialize(file, typeof(List<Chord>));
                data = temp;
            }
            return data;
        }
    }  
}
