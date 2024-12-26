namespace Course_3sem;

public interface IFilmService
{
    void AddFilm(Film film);
    List<Film> GetFilms();
    void SaveToJson(); // Метод для сохранения в JSON
    void LoadFromJson(); // Метод для загрузки из JSON
    void ClearData();
}