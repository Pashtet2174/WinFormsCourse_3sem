

using System.Text.Json.Serialization;

namespace WinFormsCourse_3sem
{
    public class Vendor
    {
        private string _name;
        private string _legalAddress;
        private string _bankName;
        private string _bankAccountNumber;
        private string _inn;
        private List<Film> _films;

        public string Name
        {
            get { return _name; }
            set
            {
                if (!VendorValidator.ValidateName(value))
                    throw new ArgumentException("Некорректное название. Оно не должно быть пустым и должно содержать до 100 символов.");
                _name = value;
            }
        }

        public string LegalAddress
        {
            get { return _legalAddress; }
            set
            {
                if (!VendorValidator.ValidateLegalAddress(value))
                    throw new ArgumentException("Некорректный юридический адрес. Он не должен быть пустым и должен содержать до 200 символов.");
                _legalAddress = value;
            }
        }

        public string BankName
        {
            get { return _bankName; }
            set
            {
                if (!VendorValidator.ValidateBankName(value))
                    throw new ArgumentException("Некорректное название банка. Оно должно содержать до 100 символов.");
                _bankName = value;
            }
        }

        public string BankAccountNumber
        {
            get { return _bankAccountNumber; }
            set
            {
                if (!VendorValidator.ValidateBankAccountNumber(value))
                    throw new ArgumentException("Некорректный номер банковского счёта. Он должен содержать 20 цифр.");
                _bankAccountNumber = value;
            }
        }

        public string Inn
        {
            get { return _inn; }
            set
            {
                if (!VendorValidator.ValidateInn(value))
                    throw new ArgumentException("Некорректный ИНН. Он должен содержать 10 или 12 цифр.");
                _inn = value;
            }
        }
        public List<Film> Films
        {
            get { return _films; }
            set
            {
                if (value == null)
                    _films = new List<Film>();
                else
                    _films = value;
            }
        }
        
        public Vendor(string name, string legalAddress, string bankName, string bankAccountNumber, string inn)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "Название не может быть null.");
            LegalAddress = legalAddress ?? throw new ArgumentNullException(nameof(legalAddress), "Юридический адрес не может быть null.");
            BankName = bankName ?? throw new ArgumentNullException(nameof(bankName), "Название банка не может быть null.");
            BankAccountNumber = bankAccountNumber ?? throw new ArgumentNullException(nameof(bankAccountNumber), "Номер банковского счёта не может быть null.");
            Inn = inn ?? throw new ArgumentNullException(nameof(inn), "ИНН не может быть null.");
            Films = new List<Film>();
        }

        public void AddFilm(Film film)
        {
            Films.Add(film);
        }
    }
}