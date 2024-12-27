using WinFormsCourse_3sem;

namespace WinFormsCourse_3sem;
public class FilmService : IFilmService
{
    private readonly List<Film> _films = new();

    public void AddFilm(Film film)
    {
        _films.Add(film);
    }

    public List<Film> GetFilms()
    {
        return _films;
    }
}