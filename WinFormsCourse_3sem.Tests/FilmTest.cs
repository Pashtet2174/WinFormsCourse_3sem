using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsCourse_3sem;

namespace WinFormsCourse_3sem.Tests;

[TestClass]
[TestSubject(typeof(Film))]
public class FilmTest
{

    [TestMethod]
    public void Constructor_ShouldInitializeProperties_WhenValidArgumentsProvided()
    {
        string name = "Inception";
        string category = "Sci-Fi";
        string scriptwriter = "Christopher Nolan";
        string productionDirector = "Christopher Nolan";
        string productionCompany = "Warner Bros.";
        int releaseYear = 2010;
        decimal cost = 160_000_000m;
        
        var film = new Film(name, category, scriptwriter, productionDirector, productionCompany, releaseYear, cost);
        
        Assert.AreEqual(name, film.Name);
        Assert.AreEqual(category, film.Category);
        Assert.AreEqual(scriptwriter, film.Scriptwriter);
        Assert.AreEqual(productionDirector, film.ProductionDirector);
        Assert.AreEqual(productionCompany, film.ProductionCompany);
        Assert.AreEqual(releaseYear, film.ReleaseYear);
        Assert.AreEqual(cost, film.Cost);
    }

    [TestMethod]
    public void ReleaseYear_Setter_ShouldThrowException_WhenYearInFuture()
    {
        Assert.ThrowsException<ArgumentException>(() => new Film("Film", "Category", "Scriptwriter", "Director", "Company", DateTime.Now.Year + 1, 100));
    }

    [TestMethod]
    public void Cost_Setter_ShouldThrowException_WhenCostIsZeroOrNegative()
    {
        Assert.ThrowsException<ArgumentException>(() => new Film("Film", "Category", "Scriptwriter", "Director", "Company", 2023, -1));
    }

        
}