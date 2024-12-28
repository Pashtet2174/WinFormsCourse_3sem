using Newtonsoft.Json; 
using JsonException = Newtonsoft.Json.JsonException;

namespace WinFormsCourse_3sem
{
    public static class FileManagement
    { 
    
        static JsonSerializerSettings settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto,
            Formatting = Newtonsoft.Json.Formatting.Indented,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        const string fileName = "DataContainer.json";

        public static string SerializeDataContainer(DataContainer data)
        {
            return JsonConvert.SerializeObject(data, settings);
        } 

        public static DataContainer DeserializeDataContainer(string json)
        {
            return JsonConvert.DeserializeObject<DataContainer>(json, settings);
        }

        public static async Task SaveToFileAsync(DataContainer data)
        {
            try
            {
                string json = SerializeDataContainer(data);
                await File.WriteAllTextAsync(fileName, json);
                Console.WriteLine("Data successfully saved to file.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка записи в файл: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
            }
        }

        public static async Task<DataContainer> GetFromFileAsync()
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    throw new FileNotFoundException();
                }
                string json = await File.ReadAllTextAsync(fileName);
                return DeserializeDataContainer(json);
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Файл не найден: {ex.Message}");
                return null;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Ошибка чтения JSON: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
                return null;
            }
        }

        public static void DeleteFile()
        {
            File.Delete(fileName);
        }
    }
} 
 

