using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsCourse_3sem;

namespace WinFormsCourse_3sem.Tests;

[TestClass]
[TestSubject(typeof(VendorService))]
public class VendorServiceTest
{
    private VendorService _vendorService;

    [TestInitialize]
    public void Setup()
    {
        _vendorService = new VendorService();
    }

    [TestMethod]
    public void AddVendor_ShouldAddVendorToList()
    {
        var vendor = new Vendor("Valid Name", "Valid Address", "Valid Bank", "12345678901234567890", "1234567890");
        
        _vendorService.AddVendor(vendor);
        
        var vendors = _vendorService.GetVendors();
        Assert.AreEqual(1, vendors.Count);
        Assert.AreEqual(vendor, vendors[0]);
    }

    [TestMethod]
    public void GetVendors_ShouldReturnAllVendors()
    {
        var vendor1 = new Vendor("Vendor1", "Address1", "Bank1", "12345678901234567890", "1234567890");
        var vendor2 = new Vendor("Vendor2", "Address2", "Bank2", "09876543210987654321", "0987654321");
        _vendorService.AddVendor(vendor1);
        _vendorService.AddVendor(vendor2);
        
        var vendors = _vendorService.GetVendors();
        
        Assert.AreEqual(2, vendors.Count);
        Assert.IsTrue(vendors.Contains(vendor1));
        Assert.IsTrue(vendors.Contains(vendor2));
    }

    [TestMethod]
    public void AddFilmToVendor_ShouldAddFilmToVendorFilmsList()
    {
        var vendor = new Vendor("Valid Name", "Valid Address", "Valid Bank", "12345678901234567890", "1234567890");
        var film = new Film("Film Name", "Category", "Scriptwriter", "Director", "Production Company", 2023, 100_000m);
        
        _vendorService.AddFilmToVendor(vendor, film);
        
        Assert.AreEqual(1, vendor.Films.Count);
        Assert.AreEqual(film, vendor.Films[0]);
    }

    [TestMethod]
    public void ValidateVendor_ShouldReturnNull_WhenAllDataIsValid()
    {
        string validName = "Valid Name";
        string validAddress = "Valid Address";
        string validBank = "Valid Bank";
        string validBankAccountNumber = "12345678901234567890";
        string validInn = "1234567890";
        
        var result = _vendorService.ValidateVendor(validName, validAddress, validBank, validBankAccountNumber, validInn);
        
        Assert.IsNull(result);
    }

    [TestMethod]
    public void CreateVendor_ShouldAddVendorToList()
    {
        string validName = "Valid Name";
        string validAddress = "Valid Address";
        string validBank = "Valid Bank";
        string validBankAccountNumber = "12345678901234567890";
        string validInn = "1234567890";
        
        _vendorService.CreateVendor(validName, validAddress, validBank, validBankAccountNumber, validInn);
        
        var vendors = _vendorService.GetVendors();
        Assert.AreEqual(1, vendors.Count);
        Assert.AreEqual(validName, vendors[0].Name);
        Assert.AreEqual(validAddress, vendors[0].LegalAddress);
    }
}