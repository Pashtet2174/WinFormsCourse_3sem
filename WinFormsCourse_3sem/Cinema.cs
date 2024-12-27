using System.Text.Json.Serialization;
using WinFormsCourse_3sem;

namespace WinFormsCourse_3sem;

public class Cinema
{
    
    private string _name;
    private string _address;
    private string _phone;
    private int _seatCapacity;
    private string _director;
    private string _owner;
    private string _bankName; 
    private string _bankAccountNumber;
    private string _inn;

    public string Name
    {
        get { return _name; }
        set
        {
            if (!CinemaValidator.ValidateName(value))
                throw new ArgumentException("Некорректное название кинотеатра. Оно должно содержать до 100 символов.");
            _name = value;
        }
    }
    
    public string Address
    {
        get { return _address; }
        set
        {
            if (!CinemaValidator.ValidateAddress(value))
                throw new ArgumentException("Некорректный адрес кинотеатра. Он должен содержать до 200 символов.");
            _address = value;
        }
    }
    public string Phone
    {
        get { return _phone; }
        set
        {
            if (!CinemaValidator.ValidatePhone(value))
                throw new ArgumentException("Некорректный номер телефона. Он должен содержать 10 цифр.");
            _phone = value;
        }
    }
    public int SeatCapacity
    {
        get { return _seatCapacity; }
        set
        {
            if (!CinemaValidator.ValidateSeatCapacity(value))
                throw new ArgumentException("Некорректная вместимость. Она должна быть больше 0 и не превышать 10000.");
            _seatCapacity = value;
        }
    }
    public string Director
    {
        get { return _director; }
        set
        {
            if (!CinemaValidator.ValidateDirector(value))
                throw new ArgumentException("Некорректное имя директора. Оно должно содержать до 100 символов.");
            _director = value;
        }
    }

    public string Owner
    {
        get { return _owner; }
        set
        {
            if (!CinemaValidator.ValidateOwner(value))
                throw new ArgumentException("Некорректное имя владельца. Оно должно содержать до 100 символов.");
            _owner = value;
        }
    }

    public string BankName
    {
        get { return _bankName; }
        set
        {
            if (!CinemaValidator.ValidateBankName(value))
                throw new ArgumentException("Некорректное название банка. Оно должно содержать до 100 символов.");
            _bankName = value;
        }
    }

    public string BankAccountNumber
    {
        get { return _bankAccountNumber; }
        set
        {
            if (!CinemaValidator.ValidateBankAccountNumber(value))
                throw new ArgumentException("Некорректный номер банковского счёта. Он должен содержать 20 цифр.");
            _bankAccountNumber = value;
        }
    }

    public string Inn
    {
        get { return _inn; }
        set
        {
            if (!CinemaValidator.ValidateInn(value))
                throw new ArgumentException("Некорректный ИНН. Он должен содержать 10 или 12 символов.");
            _inn = value;
        }
    }

    public Cinema(string name, string address, string phone, int seatCapacity, string director, string owner, string bankName, string bankAccountNumber, string inn)
    {
        Name = name;
        Address = address;
        Phone = phone;
        SeatCapacity = seatCapacity;
        Director = director;
        Owner = owner;
        BankName = bankName;
        BankAccountNumber = bankAccountNumber;
        Inn = inn;
    }
    
}

