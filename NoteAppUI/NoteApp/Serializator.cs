using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    public static class Serializator
    {
        /// <summary>
        ///     Метод для сохранения списка в файл
        /// </summary>
        /// <param name="data">Список, который нужно сохранить</param>
        /// <param name="path">Куда сохранить файл</param>
        public static void SaveFile(List<Chord> data, string path)
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
        public static List<Chord> ReadFile(string path)
        {
            List<Chord> data;
            using (var file = File.OpenText(path))
            {
                var serializer = new JsonSerializer();
                data = (List<Chord>) serializer.Deserialize(file, typeof(List<Chord>));
            }
            return data;
        }
    }
}