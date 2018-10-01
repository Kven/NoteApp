using System.IO;
using Newtonsoft.Json;

namespace NoteApp.Class
{
    public class JsonFiles
    {
        JsonSerializer serializer = new JsonSerializer();
        
            //Открываем поток для записи в файл с указанием пути
        public void SaveFile(ChordsList list)
        {
            using (StreamWriter sw = new StreamWriter(@"c:\json.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаем объект, который хотим сериализовать
                serializer.Serialize(writer, list);
            }
        }

        public void ReadFile()
        {
            //Создаём переменную, в которую поместим результат десериализации
            ChordsList list = null;
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(@"c:\json.txt"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                list = (ChordsList)serializer.Deserialize(reader);
            }
        }
    }
      
}
