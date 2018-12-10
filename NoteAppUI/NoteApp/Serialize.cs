using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    public static class Serialize
    {
        /// <summary>
        ///     Метод для сохранения списка в файл
        /// </summary>
        /// <param name="data">Список, который нужно сохранить</param>
        /// <param name="path">Куда сохранить файл</param>
        public static void SaveFile(ListOfChords data, string path)
        {
            using (var file = File.CreateText(path))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }

        /// <summary>
        ///     Метод для считывания файла и импорта из него значений в список
        /// </summary>
        /// <returns>Список аккордов, которые сохранены в файле</returns>
        public static ListOfChords ReadFile(string path)
        {
            ListOfChords data;
            using (var file = File.OpenText(path))
            {
                var serializer = new JsonSerializer();
				data = (ListOfChords) serializer.Deserialize(file, typeof(ListOfChords));
            }
            return data;
        }
    }
}