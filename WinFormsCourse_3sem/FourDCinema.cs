using WinFormsCourse_3sem;

namespace Course_3sem;

public class FourDCinema : Cinema
{
    private string _effect;

    public string Effect
    {
        get { return _effect; }
        set
        {
            if(!CinemaValidator.ValidateEffect(value))
                throw new ArgumentException("Некорректное название эффекта. Оно должно содержать до 100 символов.");
            _effect = value;
        }
    }

    public FourDCinema(string name, string address, string phone, int seatCapacity, string director, string owner, string bankName, string bankAccount, string inn, string cinemaType,  string effect)
        : base(name, address, phone, seatCapacity, director, owner, bankName, bankAccount, inn, cinemaType)
    {
        Effect = effect;
    }
    
}