namespace WinFormsCourse_3sem;

public partial class ShowCinemasForm : Form
{ 
    private readonly ICinemaService _cinemaService;
    public ShowCinemasForm( ICinemaService cinemaService)
    {
        _cinemaService = cinemaService;
        InitializeComponent();
        LoadData();
    }
    
    private void LoadData()
    {
        cinemasGridView.Rows.Clear();
        var cinemas = _cinemaService.GetCinemas();
        foreach (var cinema in cinemas)
        {
            cinemasGridView.Rows.Add(
                cinema.Name,
                cinema.Address,
                cinema.Phone,
                cinema.SeatCapacity,
                cinema.Director,
                cinema.Owner,
                cinema.BankName,
                cinema.BankAccountNumber,
                cinema.Inn
            );
        }
    }
}