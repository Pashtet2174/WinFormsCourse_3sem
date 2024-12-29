using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsCourse_3sem;

namespace WinFormsCourse_3sem.Tests;

[TestClass]
[TestSubject(typeof(RentService))]
public class RentServiceTest
{
    private RentService _rentService;
    private Cinema _cinema;
    private Film _film;

    [TestInitialize]
    public void Setup()
    {
        _rentService = new RentService();
        
        _cinema = new Cinema(
            name: "Test Cinema",
            address: "Test Address",
            phone: "1234567890",
            seatCapacity: 100,
            director: "Director Name",
            owner: "Owner Name",
            bankName: "Test Bank",
            bankAccountNumber: "12345678901234567890",
            inn: "1234567890"
        );
        
        _film = new Film(
            name: "Test Film",
            category: "Drama",
            scriptwriter: "John Doe",
            productionDirector: "Jane Smith",
            productionCompany: "Studio Inc.",
            releaseYear: 2023,
            cost: 150_000m
        );
    }

    [TestMethod]
    public void AddRent_ShouldAddRentToList()
    {
        var rent = new Rent(_cinema, _film, DateTime.Now, DateTime.Now.AddDays(10), 10_000m);

        _rentService.AddRent(rent);

        var rents = _rentService.GetRents();
        Assert.AreEqual(1, rents.Count, "Должен быть один объект Rent в списке.");
        Assert.AreSame(rent, rents[0], "Добавленный объект Rent должен совпадать с исходным.");
    }

    [TestMethod]
    public void GetRents_ShouldReturnAllRents()
    {
        var rent1 = new Rent(_cinema, _film, DateTime.Now, DateTime.Now.AddDays(10), 10_000m);
        var rent2 = new Rent(_cinema, _film, DateTime.Now, DateTime.Now.AddDays(20), 15_000m);

        _rentService.AddRent(rent1);
        _rentService.AddRent(rent2);

        var rents = _rentService.GetRents();

        Assert.AreEqual(2, rents.Count, "Должно быть два объекта Rent в списке.");
        Assert.IsTrue(rents.Contains(rent1), "Список должен содержать rent1.");
        Assert.IsTrue(rents.Contains(rent2), "Список должен содержать rent2.");
    }

    [TestMethod]
    public void CreateRent_ShouldAddRentToService()
    {
        DateTime startDate = DateTime.Now;
        DateTime endDate = DateTime.Now.AddDays(7);
        decimal rentalPrice = 20_000m;

        _rentService.CreateRent(_cinema, _film, startDate, endDate, rentalPrice);

        var rents = _rentService.GetRents();
        Assert.AreEqual(1, rents.Count, "Должен быть один объект Rent в списке.");
        Assert.AreEqual(_cinema, rents[0].Cinema, "Кинотеатр в Rent должен совпадать.");
        Assert.AreEqual(_film, rents[0].Film, "Фильм в Rent должен совпадать.");
        Assert.AreEqual(startDate, rents[0].StartDate, "Дата начала в Rent должна совпадать.");
        Assert.AreEqual(endDate, rents[0].EndDate, "Дата окончания в Rent должна совпадать.");
        Assert.AreEqual(rentalPrice, rents[0].RentalPrice, "Цена аренды в Rent должна совпадать.");
    }

}