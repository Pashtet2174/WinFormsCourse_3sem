namespace WinFormsCourse_3sem;

public interface IRentService
{
    void AddRent(Rent rent);
    List<Rent> GetRents();

    void CreateRent(Cinema? сinema, Film? film, DateTime startDate, DateTime endDate, decimal rentalPrice);
}