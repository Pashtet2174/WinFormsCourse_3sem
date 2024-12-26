namespace WinFormsCourse_3sem;

public static class CinemaValidator
{
    public static bool ValidateName(string name)
    {
        return name.Length <= 100;
    }
    
    public static bool ValidateAddress(string address)
    {
        return address.Length <= 200;
    }

    public static bool ValidatePhone(string phone)
    {
        return phone.Length == 10 && phone.All(char.IsDigit);
    }

    public static bool ValidateSeatCapacity(int seatCapacity)
    {
        return seatCapacity > 0 && seatCapacity <= 10000; 
    }

    public static bool ValidateDirector(string director)
    {
        return director.Length <= 100;
    }

    public static bool ValidateOwner(string owner)
    {
        return owner.Length <= 100;
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

    public static bool ValidateParkingCapacity(int parkingCapacity)
    {
        return parkingCapacity > 0 && parkingCapacity <= 100; 
    }

    public static bool ValidateEffect(string effect)
    {
        return effect.Length <= 100;
    }

    public static bool ValidateScreenType(string screenType)
    {
        return screenType.Length <= 100;
    }
}