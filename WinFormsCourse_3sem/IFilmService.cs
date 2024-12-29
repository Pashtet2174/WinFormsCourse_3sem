namespace WinFormsCourse_3sem;

public interface IFilmService
{
    void AddFilm(Film film);
    List<Film> GetFilms();
    string ValidateFilm(string name, string category, string scriptwriter, string productionDirector, string productionCompany, string releaseYear, string cost);
    Film CreateFilm(string name, string category, string scriptwriter, string productionDirector, string productionCompany, int releaseYear, decimal cost);

}