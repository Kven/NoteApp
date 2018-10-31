using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    public class JsonFiles
    {
        public static void SaveFile(ChordsList data)
        {
            using (StreamWriter file = File.CreateText(@"D:\path.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }

        public static void ReadFile(string add)
        {
            ChordsList list = null;
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(@add))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                list = (ChordsList)serializer.Deserialize(reader);
            }
        }
    }
      
}
