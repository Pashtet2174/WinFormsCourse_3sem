
using System.Text.Json.Serialization;
using WinFormsCourse_3sem;

namespace WinFormsCourse_3sem;
public class Film
{
    private string _name;
    private string _category;
    private string _scriptwriter;
    private string _productionDirector;
    private string _productionCompany;
    private int _releaseYear;
    private decimal _cost;

    public string Name
    {
        get { return _name; }
        set
        {
            if (!FilmValidator.ValidateName(value))
                throw new ArgumentException("Некорректное название фильма. Оно должно содержать до 100 символов.");
            _name = value;
        }
    }

    public string Category
    {
        get { return _category; }
        set
        {
            if (!FilmValidator.ValidateCategory(value))
                throw new ArgumentException("Некорректная категория фильма. Она должна содержать до 50 символов.");
            _category = value;
        }
    }

    public string Scriptwriter
    {
        get { return _scriptwriter; }
        set
        {
            if (!FilmValidator.ValidateScriptwriter(value))
                throw new ArgumentException("Некорректное автор сценария. Оно должно содержать до 100 символов.");
            _scriptwriter = value;
        }
    }

    public string ProductionDirector
    {
        get { return _productionDirector; }
        set
        {
            if (!FilmValidator.ValidateProductionDirector(value))
                throw new ArgumentException("Некорректное имя режиссёра-постановщика. Оно должно содержать до 100 символов.");
            _productionDirector = value;
        }
    }

    public string ProductionCompany
    {
        get { return _productionCompany; }
        set
        {
            if (!FilmValidator.ValidateProductionCompany(value))
                throw new ArgumentException("Некорректное название компании-производителя. Оно должно содержать до 100 символов.");
            _productionCompany = value;
        }
    }

    public int ReleaseYear
    {
        get { return _releaseYear; }
        set
        {
            if (!FilmValidator.ValidateReleaseYear(value))
                throw new ArgumentException("Некорректный год выпуска. Он должен быть не позже текущего года.");
            _releaseYear = value;
        }
    }

    public decimal Cost
    {
        get {return _cost;}
        set
        {
            if (!FilmValidator.ValidateCost(value))
                throw new ArgumentException("Некорректная стоимость. Она должна быть больше 0.");
            _cost = value;
        }
    }
    
    
    public Film(string name, string category, string scriptwriter, string productionDirector, string productionCompany,
        int releaseYear, decimal cost)
    {
        Name = name;
        Category = category;
        Scriptwriter = scriptwriter;
        ProductionDirector = productionDirector;
        ProductionCompany = productionCompany;
        ReleaseYear = releaseYear;
        Cost = cost;
    }
}