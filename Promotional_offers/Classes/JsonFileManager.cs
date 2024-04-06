using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotional_offers.Classes
{
    public class JsonFileManager
    {
        // Зберегти об'єкт у файл JSON
        public static void SaveToJson<T>(List<T> list, string filePath)
        {
            string jsonData = JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        // Зчитати об'єкт з файлу JSON
        public static List<T> LoadFromJson<T>(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<T>>(jsonData);
            }
            else
            {
                return new List<T>();
            }
        }
    }
}
