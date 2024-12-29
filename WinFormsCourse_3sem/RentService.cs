namespace WinFormsCourse_3sem;

public class RentService : IRentService
{
    private readonly List<Rent> _rents = new ();
    public void AddRent(Rent rent)
    {
        _rents.Add(rent);
    }

    public List<Rent> GetRents()
    {
        return _rents;
    }

    public void CreateRent(Cinema сinema, Film film, DateTime startDate, DateTime endDate, decimal rentalPrice)
    {
        Rent rent = new Rent(сinema, film, startDate, endDate, rentalPrice);
        AddRent(rent);
    }
}