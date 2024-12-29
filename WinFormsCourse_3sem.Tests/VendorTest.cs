using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsCourse_3sem;

namespace WinFormsCourse_3sem.Tests;

[TestClass]
[TestSubject(typeof(Vendor))]
public class VendorTest
{
    [TestMethod]
    public void Constructor_ShouldInitializeProperties_WhenValidArgumentsProvided()
    {
        string name = "Valid Name";
        string legalAddress = "Valid Address";
        string bankName = "Valid Bank";
        string bankAccountNumber = "12345678901234567890";
        string inn = "1234567890";
        
        var vendor = new Vendor(name, legalAddress, bankName, bankAccountNumber, inn);
        
        Assert.AreEqual(name, vendor.Name);
        Assert.AreEqual(legalAddress, vendor.LegalAddress);
        Assert.AreEqual(bankName, vendor.BankName);
        Assert.AreEqual(bankAccountNumber, vendor.BankAccountNumber);
        Assert.AreEqual(inn, vendor.Inn);
        Assert.IsNotNull(vendor.Films);
        Assert.AreEqual(0, vendor.Films.Count);
    }

    [TestMethod]
    public void BankName_Setter_ShouldThrowException_WhenInvalidBankNameProvided()
    {
        var vendor = new Vendor("Valid Name", "Valid Address", "Valid Bank", "12345678901234567890", "1234567890");
        
        Assert.ThrowsException<ArgumentException>(() => vendor.BankName = new string('a', 101));
    }

    [TestMethod]
    public void BankAccountNumber_Setter_ShouldThrowException_WhenInvalidBankAccountNumberProvided()
    {
        var vendor = new Vendor("Valid Name", "Valid Address", "Valid Bank", "12345678901234567890", "1234567890");
        
        Assert.ThrowsException<ArgumentException>(() => vendor.BankAccountNumber = "12345");
    }

    [TestMethod]
    public void Inn_Setter_ShouldThrowException_WhenInvalidInnProvided()
    {
        var vendor = new Vendor("Valid Name", "Valid Address", "Valid Bank", "12345678901234567890", "1234567890");
        
        Assert.ThrowsException<ArgumentException>(() => vendor.Inn = "123");
    }

    [TestMethod]
    public void Films_Setter_ShouldInitializeEmptyList_WhenNullProvided()
    {
        var vendor = new Vendor("Valid Name", "Valid Address", "Valid Bank", "12345678901234567890", "1234567890");
        
        vendor.Films = null;
        
        Assert.IsNotNull(vendor.Films);
        Assert.AreEqual(0, vendor.Films.Count);
    }

    
}