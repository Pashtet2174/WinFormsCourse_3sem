using WinFormsCourse_3sem;

namespace Course_3sem;

public class OutdoorCinema : Cinema
{
    private int _parkingCapacity;
    public int ParkingCapacity
    {
        get { return _parkingCapacity; }
        set
        {
            if(!CinemaValidator.ValidateParkingCapacity(value))
                throw new ArgumentException("Некорректное количество мест. Оно должно быть не более 100.");
            _parkingCapacity = value;
        }
    }

    public OutdoorCinema(string name, string address, string phone, int seatCapacity,  string direсtor, string owner,  string bankName, string bankAccount, string innCinema,string cinemaType,  int parkingCapacity )
        : base(name, address, phone, seatCapacity,direсtor, owner, bankName, bankAccount, innCinema, cinemaType)
    {
        ParkingCapacity = parkingCapacity;
    }
    
}