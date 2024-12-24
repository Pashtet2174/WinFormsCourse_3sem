namespace Course_3sem;

public class Rent
{
    private Cinema _cinema;
    private Film _film;
    private DateTime _startDate;
    private DateTime _endDate;
    private decimal _rentalPrice;

    // Свойства
    public Cinema Cinema
    {
        get => _cinema;
        set => _cinema = value;
    }

    public Film Film
    {
        get => _film;
        set => _film = value;
    }

    public DateTime StartDate
    {
        get => _startDate;
        set => _startDate = value;
    }

    public DateTime EndDate
    {
        get => _endDate;
        set => _endDate = value;
    }

    public decimal RentalPrice
    {
        get => _rentalPrice;
        set => _rentalPrice = value;
    }

    
    
    public Rent(Cinema cinema, Film film, DateTime startDate, DateTime endDate, decimal rentalPrice)
    {
        Cinema = cinema;
        Film = film;
        StartDate = startDate;
        EndDate = endDate;
        RentalPrice = rentalPrice;
    }
}
