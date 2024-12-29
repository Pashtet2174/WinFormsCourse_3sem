namespace WinFormsCourse_3sem;

public class CinemaService : ICinemaService
{
    private readonly List<Cinema> _cinemas = new();

    public void AddCinema(Cinema cinema)
    {
        _cinemas.Add(cinema);
    }

    public List<Cinema> GetCinemas()
    {
        return _cinemas;
    }

    public string ValidateCinema(string name, string address, string phone, string seatCapacityText, string director, string owner,
        string bankName, string bankAccountNumber, string inn)
    {
        if (!CinemaValidator.ValidateName(name))
        {
            return"Некорректное название кинотеатра. Оно должно содержать до 100 символов.";
        }

        if (!CinemaValidator.ValidateAddress(address))
        {
            return"Некорректный адрес. Он должен содержать до 200 символов.";
        }

        if (!CinemaValidator.ValidatePhone(phone))
        {
            return"Некорректный номер телефона. Он должен содержать 10 цифр.";
        }

        if (!int.TryParse(seatCapacityText, out int seatCapacity) || !CinemaValidator.ValidateSeatCapacity(seatCapacity))
        {   
            return"Введите корректную вместимость. Она должна быть больше 0 и не превышать 10000.";
        }

        if (!CinemaValidator.ValidateDirector(director))
        {
            return"Некорректное имя директора. Оно должно содержать до 100 символов.";
        }

        if (!CinemaValidator.ValidateOwner(owner))
        {
            return"Некорректное имя владельца. Оно должно содержать до 100 символов.";
        }

        if (!CinemaValidator.ValidateBankName(bankName))
        {
            return"Некорректное название банка. Оно должно содержать до 100 символов.";
        }

        if (!CinemaValidator.ValidateBankAccountNumber(bankAccountNumber))
        {
            return"Некорректный номер банковского счета. Он должен содержать 20 цифр.";
        }

        if (!CinemaValidator.ValidateInn(inn))
        {
            return"Некорректный ИНН. Он должен содержать 10 или 12 цифр.";
        }
        return null;
    }

    public void CreateCinema(string name, string address, string phone, int seatCapacity, string director, string owner,
        string bankName, string bankAccountNumber, string inn)
    {
        Cinema cinema = new Cinema(name, address, phone, seatCapacity, director, owner, bankName, bankAccountNumber, inn);
        
        AddCinema(cinema);
    }

}