using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsCourse_3sem;

namespace WinFormsCourse_3sem.Tests;

[TestClass]
[TestSubject(typeof(FilmService))]
public class FilmServiceTest
{
    private FilmService _filmService;

    [TestInitialize]
    public void Setup()
    {
        _filmService = new FilmService(); 
    }

    [TestMethod]
    public void AddFilm_ShouldAddFilmToList()
    {
        var film = new Film("Test Film", "Action", "John Doe", "Jane Doe", "Test Studio", 2023, 100000m);

        _filmService.AddFilm(film);

        var films = _filmService.GetFilms();
        Assert.AreEqual(1, films.Count, "Должен быть один фильм в списке.");
        Assert.AreSame(film, films[0], "Добавленный фильм должен совпадать с исходным.");
    }

    [TestMethod]
    public void ValidateFilm_ShouldReturnNullForValidInput()
    {
        var result = _filmService.ValidateFilm("Test Film", "Action", "John Doe", "Jane Doe", "Test Studio", "2023", "100000");

        Assert.IsNull(result, "Для валидных данных результат должен быть null.");
    }

    [TestMethod]
    public void CreateFilm_ShouldAddFilmToService()
    {
        var name = "Test Film";
        var category = "Action";
        var scriptwriter = "John Doe";
        var productionDirector = "Jane Doe";
        var productionCompany = "Test Studio";
        var releaseYear = 2023;
        var cost = 100000m;
        
        _filmService.CreateFilm(name, category, scriptwriter, productionDirector, productionCompany, releaseYear, cost);

        var films = _filmService.GetFilms();
        Assert.AreEqual(1, films.Count, "Должен быть один фильм в списке.");
        Assert.AreEqual(name, films[0].Name, "Название фильма должно совпадать.");
        Assert.AreEqual(category, films[0].Category, "Категория фильма должна совпадать.");
        Assert.AreEqual(scriptwriter, films[0].Scriptwriter, "Автор сценария должен совпадать.");
        Assert.AreEqual(productionDirector, films[0].ProductionDirector, "Режиссёр должен совпадать.");
        Assert.AreEqual(productionCompany, films[0].ProductionCompany, "Компания-производитель должна совпадать.");
        Assert.AreEqual(releaseYear, films[0].ReleaseYear, "Год выпуска должен совпадать.");
        Assert.AreEqual(cost, films[0].Cost, "Стоимость должна совпадать.");
    }

    [TestMethod]
    public void ValidateFilm_ShouldReturnErrorMessageForInvalidReleaseYear()
    {
        var result = _filmService.ValidateFilm("Test Film", "Action", "John Doe", "Jane Doe", "Test Studio", "2025", "100000");

        Assert.AreEqual("Введите корректный год выхода на экран. Он должен быть не позже текущего года.", result);
    }

    [TestMethod]
    public void ValidateFilm_ShouldReturnErrorMessageForInvalidCost()
    {
        var result = _filmService.ValidateFilm("Test Film", "Action", "John Doe", "Jane Doe", "Test Studio", "2023", "-100");

        Assert.AreEqual("Введите корректную стоимость приобретения. Она должна быть больше 0.", result);
    }

    
}