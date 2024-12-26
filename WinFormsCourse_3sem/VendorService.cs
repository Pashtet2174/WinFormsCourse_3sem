using WinFormsCourse_3sem;

namespace Course_3sem;

public class VendorService : IVendorService

{
    private readonly List<Vendor> _vendors = new();
    private readonly string _filePath = "cinemas.json";
    public void AddVendor(Vendor vendor)
    {
        _vendors.Add(vendor);
    }

    public List<Vendor> GetVendors()
    {
        return _vendors;
    }

    public void AddFilmToVendor(Vendor vendor, Film film)
    {
        vendor.AddFilm(film);
    }
    
    public void SaveToJson()
    {
        SaveJson.SaveToFile(_filePath, _vendors);
    }

    public void LoadFromJson()
    {
        _vendors.Clear();
        _vendors.AddRange(SaveJson.LoadFromFile<List<Vendor>>(_filePath));
    }
    public void ClearData()
    {
        _vendors.Clear();
        SaveJson.SaveToFile(_filePath, _vendors); // Сохраняем пустой список в файл
    }
}