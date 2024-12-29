using WinFormsCourse_3sem;

namespace WinFormsCourse_3sem;
public class FilmService : IFilmService
{
    private readonly IVendorService _vendorService;
    private readonly List<Film> _films = new();

    public void AddFilm(Film film)
    {
        _films.Add(film);
    }

    public List<Film> GetFilms()
    {
        return _films;
    }

    public string ValidateFilm(string name, string category, string scriptwriter, string productionDirector,
        string productionCompany, string releaseYearText, string costText)
    {if (!FilmValidator.ValidateName(name))
        {
            return"Некорректное название фильма. Оно должно содержать до 100 символов.";
        }

        if (!FilmValidator.ValidateCategory(category))
        {
            return"Некорректная категория фильма. Она должна содержать до 50 символов.";
        }

        if (!FilmValidator.ValidateScriptwriter(scriptwriter))
        {
            return"Некорректное автор сценария. Оно должно содержать до 100 символов.";
        }

        if (!FilmValidator.ValidateProductionDirector(productionDirector))
        {
            return"Некорректное имя режиссёра-постановщика. Оно должно содержать до 100 символов.";
        }

        if (!FilmValidator.ValidateProductionCompany(productionCompany))
        {
            return"Некорректное название компании-производителя. Оно должно содержать до 100 символов.";
        }

        if (!int.TryParse(releaseYearText, out int releaseYear) || !FilmValidator.ValidateReleaseYear(releaseYear))
        {
            return"Введите корректный год выхода на экран. Он должен быть не позже текущего года.";
        }

        if (!decimal.TryParse(costText, out decimal cost) || !FilmValidator.ValidateCost(cost))
        {
            return"Введите корректную стоимость приобретения. Она должна быть больше 0.";
        }

        
        return null;
    }

    public Film CreateFilm(string name, string category, string scriptwriter, string productionDirector,
        string productionCompany, int releaseYear, decimal cost)
    {
        Film film = new Film(name, category, scriptwriter, productionDirector, productionCompany, releaseYear, cost);
        AddFilm(film);
        return film ;
    }
}