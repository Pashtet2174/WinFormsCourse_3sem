namespace WinFormsCourse_3sem;
public interface IVendorService
{
    void AddVendor(Vendor vendor);
    List<Vendor> GetVendors();
    void AddFilmToVendor(Vendor vendor, Film film);
    string ValidateVendor(string name, string legalAddress, string bank, string bankAccountNumber, string inn);
    void CreateVendor(string name, string legalAddress, string bank, string bankAccountNumber, string inn);

}