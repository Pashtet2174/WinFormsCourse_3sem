using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsCourse_3sem;

namespace WinFormsCourse_3sem.Tests;

[TestClass]
[TestSubject(typeof(Cinema))]
public class CinemaTest
{

    [TestMethod]
    public void Constructor_ShouldInitializeProperties_WhenValidArgumentsProvided()
    {
        string name = "Valid Cinema";
        string address = "Valid Address";
        string phone = "1234567890";
        int seatCapacity = 100;
        string director = "Valid Director";
        string owner = "Valid Owner";
        string bankName = "Valid Bank";
        string bankAccountNumber = "12345678901234567890";
        string inn = "1234567890";

        var cinema = new Cinema(name, address, phone, seatCapacity, director, owner, bankName, bankAccountNumber, inn);

        Assert.AreEqual(name, cinema.Name);
        Assert.AreEqual(address, cinema.Address);
        Assert.AreEqual(phone, cinema.Phone);
        Assert.AreEqual(seatCapacity, cinema.SeatCapacity);
        Assert.AreEqual(director, cinema.Director);
        Assert.AreEqual(owner, cinema.Owner);
        Assert.AreEqual(bankName, cinema.BankName);
        Assert.AreEqual(bankAccountNumber, cinema.BankAccountNumber);
        Assert.AreEqual(inn, cinema.Inn);
    }

    [TestMethod]
    public void Phone_Setter_ShouldThrowException_WhenInvalidPhoneProvided()
    {
        var cinema = new Cinema("Valid Name", "Valid Address", "1234567890", 100, "Valid Director", "Valid Owner", "Valid Bank", "12345678901234567890", "1234567890");

        Assert.ThrowsException<ArgumentException>(() => cinema.Phone = "123");
    }

    [TestMethod]
    public void SeatCapacity_Setter_ShouldThrowException_WhenInvalidSeatCapacityProvided()
    {
        var cinema = new Cinema("Valid Name", "Valid Address", "1234567890", 100, "Valid Director", "Valid Owner", "Valid Bank", "12345678901234567890", "1234567890");

        Assert.ThrowsException<ArgumentException>(() => cinema.SeatCapacity = -1);
        Assert.ThrowsException<ArgumentException>(() => cinema.SeatCapacity = 10001);
    }

    [TestMethod]
    public void Director_Setter_ShouldThrowException_WhenInvalidDirectorProvided()
    {
        var cinema = new Cinema("Valid Name", "Valid Address", "1234567890", 100, "Valid Director", "Valid Owner", "Valid Bank", "12345678901234567890", "1234567890");

        Assert.ThrowsException<ArgumentException>(() => cinema.Director = new string('a', 101));
    }

    [TestMethod]
    public void Owner_Setter_ShouldThrowException_WhenInvalidOwnerProvided()
    {
        var cinema = new Cinema("Valid Name", "Valid Address", "1234567890", 100, "Valid Director", "Valid Owner", "Valid Bank", "12345678901234567890", "1234567890");

        Assert.ThrowsException<ArgumentException>(() => cinema.Owner = new string('a', 101));
    }

    [TestMethod]
    public void BankName_Setter_ShouldThrowException_WhenInvalidBankNameProvided()
    {
        var cinema = new Cinema("Valid Name", "Valid Address", "1234567890", 100, "Valid Director", "Valid Owner", "Valid Bank", "12345678901234567890", "1234567890");

        Assert.ThrowsException<ArgumentException>(() => cinema.BankName = new string('a', 101));
    }

    [TestMethod]
    public void BankAccountNumber_Setter_ShouldThrowException_WhenInvalidBankAccountNumberProvided()
    {
        var cinema = new Cinema("Valid Name", "Valid Address", "1234567890", 100, "Valid Director", "Valid Owner", "Valid Bank", "12345678901234567890", "1234567890");

        Assert.ThrowsException<ArgumentException>(() => cinema.BankAccountNumber = "12345");
    }

    [TestMethod]
    public void Inn_Setter_ShouldThrowException_WhenInvalidInnProvided()
    {
        var cinema = new Cinema("Valid Name", "Valid Address", "1234567890", 100, "Valid Director", "Valid Owner", "Valid Bank", "12345678901234567890", "1234567890");

        Assert.ThrowsException<ArgumentException>(() => cinema.Inn = "123");
    }
}