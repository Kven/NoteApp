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

        public static Chord ReadFile<Chord>()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(@"D:\path.txt"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return (Chord)serializer.Deserialize(reader);
            }
        }
    }
      
}
