using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsCourse_3sem;

namespace WinFormsCourse_3sem.Tests;

[TestClass]
[TestSubject(typeof(Rent))]
public class RentTest
{
    private Cinema validCinema;
    private Film validFilm;

    [TestInitialize]
    public void Setup()
    {
        validCinema = new Cinema("Cinema Name", "Cinema Address", "1234567890", 200, "Director Name", "Owner Name", "Bank Name", "12345678901234567890", "1234567890");
        validFilm = new Film("Film Name", "Category", "Scriptwriter", "Director", "Production Company", 2023, 100_000m);
    }

    [TestMethod]
    public void Constructor_ShouldInitializeProperties_WhenValidArgumentsProvided()
    {
        DateTime startDate = DateTime.Now;
        DateTime endDate = DateTime.Now.AddDays(7);
        decimal rentalPrice = 5000;
        
        var rent = new Rent(validCinema, validFilm, startDate, endDate, rentalPrice);
        
        Assert.AreEqual(validCinema, rent.Cinema);
        Assert.AreEqual(validFilm, rent.Film);
        Assert.AreEqual(startDate, rent.StartDate);
        Assert.AreEqual(endDate, rent.EndDate);
        Assert.AreEqual(rentalPrice, rent.RentalPrice);
    }

    [TestMethod]
    public void Cinema_Setter_ShouldThrowException_WhenNullValueProvided()
    {
        Assert.ThrowsException<ArgumentNullException>(() => new Rent(null, validFilm, DateTime.Now, DateTime.Now.AddDays(7), 5000));
    }

    [TestMethod]
    public void Film_Setter_ShouldThrowException_WhenNullValueProvided()
    {
        Assert.ThrowsException<ArgumentNullException>(() => new Rent(validCinema, null, DateTime.Now, DateTime.Now.AddDays(7), 5000));
    }

    [TestMethod]
    public void RentalPrice_Setter_ShouldThrowException_WhenInvalidValueProvided()
    {
        decimal invalidPrice = -100;
        
        Assert.ThrowsException<ArgumentException>(() => new Rent(validCinema, validFilm, DateTime.Now, DateTime.Now.AddDays(7), invalidPrice));
    }

    [TestMethod]
    public void StartDate_ShouldSetValue_WhenValidDateProvided()
    {
        var rent = new Rent(validCinema, validFilm, DateTime.Now, DateTime.Now.AddDays(7), 5000);
        DateTime newStartDate = DateTime.Now.AddDays(-1);
        
        rent.StartDate = newStartDate;
        
        Assert.AreEqual(newStartDate, rent.StartDate);
    }

    [TestMethod]
    public void EndDate_ShouldSetValue_WhenValidDateProvided()
    {
        var rent = new Rent(validCinema, validFilm, DateTime.Now, DateTime.Now.AddDays(7), 5000);
        DateTime newEndDate = DateTime.Now.AddDays(10);
        
        rent.EndDate = newEndDate;
        Assert.AreEqual(newEndDate, rent.EndDate);
    }
}