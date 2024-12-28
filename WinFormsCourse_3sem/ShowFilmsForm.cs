using System.Globalization;

namespace WinFormsCourse_3sem;

public partial class ShowFilmsForm : Form
{
    private readonly IFilmService _filmService;
    public ShowFilmsForm(IFilmService filmService)
    {
        _filmService = filmService;
        InitializeComponent();
        LoadData();
    }
    
    private void LoadData()
    {
        filmsGridView.Rows.Clear();
        var films = _filmService.GetFilms();
        foreach (var film in films)
        {
            filmsGridView.Rows.Add(
                film.Name,
                film.Category,
                film.Scriptwriter,
                film.ProductionDirector,
                film.ProductionCompany,
                film.ReleaseYear,
                film.Cost.ToString("C", new CultureInfo("ru-RU"))
                
            );
        }
    }
    
}