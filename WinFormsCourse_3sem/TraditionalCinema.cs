using WinFormsCourse_3sem;

namespace Course_3sem;

public class TraditionalCinema : Cinema
{
    private string _screenType;
    public string ScreenType 
    {
        get { return _screenType; }
        set
        {
            if(!CinemaValidator.ValidateScreenType(value))
                throw new ArgumentException("Некорректное название экрана. Оно должно содержать до 100 символов.");
            _screenType = value;
        }
    }

    public TraditionalCinema(string name, string address, string phone, int seatCapacity, string director, string owner, string bankName, string bankAccount, string innCinema,string cinemaType, string screenType )
        : base(name, address, phone, seatCapacity, director, owner, bankName, bankAccount, innCinema, cinemaType)
    {
        ScreenType = screenType;
    }
    
}