namespace WinFormsCourse_3sem;

public static class VendorValidator
{
    public static bool ValidateName(string name)
    {
        return name.Length <= 100;
    }

    public static bool ValidateLegalAddress(string legalAddress)
    {
        return legalAddress.Length <= 200;
    }

    public static bool ValidateBankName(string bankName)
    {
        return bankName.Length <= 100;
    }

    public static bool ValidateBankAccountNumber(string bankAccountNumber)
    {
        return bankAccountNumber.Length == 20 && bankAccountNumber.All(char.IsDigit)  ;
    }

    public static bool ValidateInn(string inn)
    {
        return (inn.Length == 10 || inn.Length == 12) && inn.All(char.IsDigit);
    }
}
