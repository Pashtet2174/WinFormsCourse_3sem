using WinFormsCourse_3sem;

namespace Course_3sem;

public class RentService : IRentService
{
    private readonly List<Rent> _rents = new ();
    private readonly string _filePath = "cinemas.json";
    public void AddRent(Rent rent)
    {
        _rents.Add(rent);
    }

    public List<Rent> GetRents()
    {
        return _rents;
    }
    
    public void SaveToJson()
    {
        SaveJson.SaveToFile(_filePath, _rents);
    }

    public void LoadFromJson()
    {
        _rents.Clear();
        _rents.AddRange(SaveJson.LoadFromFile<List<Rent>>(_filePath));
    }
    
    public void ClearData()
    {
        _rents.Clear();
        SaveJson.SaveToFile(_filePath, _rents); // Сохраняем пустой список в файл
    }
}