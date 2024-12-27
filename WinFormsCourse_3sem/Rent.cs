using WinFormsCourse_3sem;

namespace Course_3sem;

public class Rent
{
    private Cinema _cinema;
    private Film _film;
    private DateTime _startDate;
    private DateTime _endDate;
    private decimal _rentalPrice;

    public Cinema Cinema
    {
        get { return _cinema; }
        set => _cinema = value ?? throw new ArgumentNullException("Кинотеатр не может быть null.");
    }

    public Film Film
    {
        get { return _film; }
        set => _film = value ?? throw new ArgumentNullException("Фильм не может быть null.");
    }

    public DateTime StartDate
    {
        get { return _startDate; }
        set { _startDate = value; }
    }

    public DateTime EndDate
    {
        get { return _endDate; }
        set { _endDate = value; }
    }

    public decimal RentalPrice
    {
        get { return _rentalPrice; }
        set
        {
            if (!RentValidator.ValidateRentalPrice(value))
                throw new ArgumentException("Некорректная стоимость аренды. Она должна быть больше 0.");
            _rentalPrice = value;
        }
    }

    public Rent(Cinema cinema, Film film, DateTime startDate, DateTime endDate, decimal rentalPrice)
    {
        Cinema = cinema ?? throw new ArgumentNullException(nameof(cinema), "Кинотеатр не может быть null.");
        Film = film ?? throw new ArgumentNullException(nameof(film), "Фильм не может быть null.");
        StartDate = startDate;
        EndDate = endDate;
        RentalPrice = rentalPrice;
    }
}
