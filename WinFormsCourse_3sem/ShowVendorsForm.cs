namespace WinFormsCourse_3sem;

public partial class ShowVendorsForm : Form
{
    private readonly IVendorService _vendorService;
    public ShowVendorsForm(IVendorService vendorService)
    {
        _vendorService = vendorService;
        InitializeComponent();
    }
}