using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    public static class Json
    {
        public static void SaveFile(List<Chord> data)
        {
            using (StreamWriter file = File.CreateText(@"D:\path.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }

        public static List<Chord> ReadFile()
        {
            List<Chord> data = null;
            using (StreamReader file = File.OpenText(@"D:\path.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Chord> temp = (List<Chord>)serializer.Deserialize(file, typeof(List<Chord>));
                data = temp;
            }
            return data;

        }
    }
      
}
