namespace WinFormsCourse_3sem;

public class RentValidator
{
    public static bool ValidateRentalPrice(decimal rentalPrice)
    {
        return rentalPrice > 0;
    }
}