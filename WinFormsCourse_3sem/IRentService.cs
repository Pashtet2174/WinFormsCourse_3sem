namespace Course_3sem;

public interface IRentService
{
    void AddRent(Rent rent);
    List<Rent> GetRents();
    void SaveToJson(); // Метод для сохранения в JSON
    void LoadFromJson(); // Метод для загрузки из JSON
    void ClearData();
}