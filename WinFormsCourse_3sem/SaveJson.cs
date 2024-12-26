using System.Text.Json;
namespace WinFormsCourse_3sem;

public class SaveJson
{
    public static void SaveToFile<T>(string filePath, T data)
    {
        var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public static T LoadFromFile<T>(string filePath) where T : new()
    {
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(json) ?? new T();
        }

        return new T();
    }
    
}