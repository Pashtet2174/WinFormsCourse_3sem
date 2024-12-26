namespace WinFormsCourse_3sem;

public static class FilmValidator
{
    public static bool ValidateName(string name)
    {
        return name.Length <= 100;
    }

    public static bool ValidateCategory(string category)
    {
        return category.Length <= 50;
    }

    public static bool ValidateScriptwriter(string scriptwriter)
    {
        return scriptwriter.Length <= 100;
    }

    public static bool ValidateProductionDirector(string productionDirector)
    {
        return productionDirector.Length <= 100;
    }

    public static bool ValidateProductionCompany(string productionCompany)
    {
        return productionCompany.Length <= 100;
    }

    public static bool ValidateReleaseYear(int releaseYear)
    {
        return releaseYear <= 2024;
    }

    public static bool ValidateCost(decimal cost)
    {
        return cost > 0;
    }
}