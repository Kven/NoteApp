using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    public class JsonFiles
    {
        public static void SaveFile(object data)
        {
            using (StreamWriter file = File.CreateText(@"D:\path.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }

        public static T ReadFile<T>(/*string add*/) where T : class 
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(@"D:\path.txt"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
      
}
