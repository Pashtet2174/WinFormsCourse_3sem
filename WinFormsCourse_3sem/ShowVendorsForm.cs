namespace WinFormsCourse_3sem;

public partial class ShowVendorsForm : Form
{
    private readonly IVendorService _vendorService;
    public ShowVendorsForm(IVendorService vendorService)
    {
        _vendorService = vendorService;
        InitializeComponent();
        LoadData();
    }
    
    private void LoadData()
    {
        vensorsGridView.Rows.Clear(); 
        var vendors = _vendorService.GetVendors();
        
        foreach (var vendor in vendors)
        {
            string filmsString;
            if (vendor.Films.Count > 0)
            {
                List<string> filmNames = new List<string>();
                foreach (var film in vendor.Films)
                {
                    filmNames.Add(film.Name);
                }
                filmsString = string.Join(", ", filmNames);
            }
            else
                filmsString = "Нет фильмов";
            
            vensorsGridView.Rows.Add(
                vendor.Name,
                vendor.LegalAddress,
                vendor.BankName,
                vendor.BankAccountNumber,
                vendor.Inn,
                filmsString
            );
        }
    }
}