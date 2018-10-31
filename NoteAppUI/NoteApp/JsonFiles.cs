using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    public class JsonFiles
    {
        public static void SaveFile(ChordsList data)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@"D:\json.txt"))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, data);
                }
            }
        }

        public static void ReadFile(string add)
        {
            ChordsList list = null;
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(@add))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                list = (ChordsList)serializer.Deserialize(reader);
            }
        }
    }
      
}
