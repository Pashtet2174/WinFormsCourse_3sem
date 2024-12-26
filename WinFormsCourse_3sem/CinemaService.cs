using WinFormsCourse_3sem;

namespace Course_3sem;

public class CinemaService : ICinemaService
{
    private readonly List<Cinema> _cinemas = new();
    private readonly string _filePath = "cinemas.json";

    public void AddCinema(Cinema cinema)
    {
        _cinemas.Add(cinema);
    }

    public List<Cinema> GetCinemas()
    {
        return _cinemas;
    }

    public void SaveToJson()
    {
        SaveJson.SaveToFile(_filePath, _cinemas);
    }

    public void LoadFromJson()
    {
        _cinemas.Clear();
        _cinemas.AddRange(SaveJson.LoadFromFile<List<Cinema>>(_filePath));
    }
    public void ClearData()
    {
        _cinemas.Clear();
        SaveJson.SaveToFile(_filePath, _cinemas); // Сохраняем пустой список в файл
    }
}