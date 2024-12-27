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
                vensorsGridView.Rows.Add(
                    vendor.Name,
                    vendor.LegalAddress,
                    vendor.BankName,
                    vendor.BankAccountNumber,
                    vendor.Inn
                );
            }
    }
}