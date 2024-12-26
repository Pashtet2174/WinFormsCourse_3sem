using WinFormsCourse_3sem;

namespace Course_3sem;

public class FilmService : IFilmService
{
    private readonly List<Film> _films = new();
    private readonly string _filePath = "cinemas.json";
    public void AddFilm(Film film)
    {
        _films.Add(film);
    }

    public List<Film> GetFilms()
    {
        return _films;
    }
    
    public void SaveToJson()
    {
        SaveJson.SaveToFile(_filePath, _films);
    }

    public void LoadFromJson()
    {
        _films.Clear();
        _films.AddRange(SaveJson.LoadFromFile<List<Film>>(_filePath));
    }
    public void ClearData()
    {
        _films.Clear();
        SaveJson.SaveToFile(_filePath, _films); // Сохраняем пустой список в файл
    }
}