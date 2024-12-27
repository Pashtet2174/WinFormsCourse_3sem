using System.Globalization;
using Course_3sem;

namespace WinFormsCourse_3sem;

public partial class ShowRentsForm : Form
{
    private readonly IRentService _rentService;
    public ShowRentsForm(IRentService rentService)
    {
        _rentService = rentService;
        InitializeComponent();
        LoadData();
    }
    
    private void LoadData()
    {
        rentsGridView1.Rows.Clear();
        var rents = _rentService.GetRents();

        foreach (var rent in rents)
        {
            rentsGridView1.Rows.Add(
                rent.Cinema.Name,
                rent.Film.Name,
                rent.StartDate.ToShortDateString(),
                rent.EndDate.ToShortDateString(),
                rent.RentalPrice.ToString("C", new CultureInfo("ru-RU"))
            );
        }
    }

    
    
    
    
    
}