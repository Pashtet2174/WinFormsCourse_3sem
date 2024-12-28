namespace WinFormsCourse_3sem;
public class VendorService : IVendorService
{
    private readonly List<Vendor> _vendors = new();
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
    public string ValidateVendor(string name, string legalAddress,string bank,string bankAccountNumber,string inn)
    
    {
        if (!VendorValidator.ValidateName(name))
        {
            return"Некорректное название поставщика киноленты. Оно не должно быть пустым и должно содержать до 100 символов.";
        }
        if (!VendorValidator.ValidateLegalAddress(legalAddress))
        {
            return"Некорректный юридический адрес. Он не должен быть пустым и должен содержать до 200 символов.";
        }
        if (!VendorValidator.ValidateBankName(bank))
        {
            return"Некорректное название банка. Оно не должно быть пустым и должно содержать до 100 символов.";
        }
        if (!VendorValidator.ValidateBankAccountNumber(bankAccountNumber))
        {
            return"Некорректный номер банковского счёта. Он должен содержать 20 цифр.";
        }
        if (!VendorValidator.ValidateInn(inn))
        {
            return"Некорректный ИНН. Он должен содержать 10 или 12 цифр.";
        }
        return null;
    }
    public void CreateVendor(string name, string legalAddress, string bank, string bankAccountNumber, string inn)
    {
        Vendor vendor = new Vendor(name, legalAddress, bank, bankAccountNumber, inn);
        AddVendor(vendor);
    }
}