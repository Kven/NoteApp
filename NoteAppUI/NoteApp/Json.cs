using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    public class Json
    {
        public void SaveFile(object data)
        {
            using (StreamWriter file = File.CreateText(@"D:\path.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }

        public List<Chord> ReadFile()
        {
            JsonSerializer js = new JsonSerializer();
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(@"d:\path.txt"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return (List<Chord>)serializer.Deserialize(reader);
            }
        }
    }
      
}
