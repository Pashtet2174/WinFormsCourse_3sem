namespace Course_3sem;

public interface ICinemaService
{
    void AddCinema(Cinema cinema);
    List<Cinema> GetCinemas();
    void SaveToJson(); // Метод для сохранения в JSON
    void LoadFromJson(); // Метод для загрузки из JSON
    void ClearData();
}