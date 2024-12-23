using Course_3sem;

namespace WinFormsCourse_3sem;

public partial class ShowRentsForm : Form
{
    private readonly ICinemaService _cinemaService;
    private readonly IFilmService _filmService;
    private readonly IVendorService _vendorService;
    private readonly IRentService _rentService;
    public ShowRentsForm(ICinemaService cinemaService, IFilmService filmService, IVendorService vendorService, IRentService rentService)
    {
        _cinemaService = cinemaService;
        _filmService = filmService;
        _vendorService = vendorService;
        _rentService = rentService;

        InitializeComponent();
    }
}