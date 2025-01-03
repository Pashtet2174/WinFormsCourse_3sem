namespace WinFormsCourse_3sem;

public partial class Form1 : Form
{
    private readonly ICinemaService _cinemaService;
    private readonly IFilmService _filmService;
    private readonly IVendorService _vendorService;
    private readonly IRentService _rentService;
    public Form1(ICinemaService cinemaService, IFilmService filmService, IVendorService vendorService,IRentService rentService)
    {
        _cinemaService = cinemaService;
        _filmService = filmService;
        _vendorService = vendorService;
        _rentService = rentService;
        InitializeComponent();
        InitializeAddVendorPanel();
        InitializeAddFilmPanel();
        InitializeAddCinemaPanel(); 
        InitializeAddRentPanel();
        Load += Form1_Load;
        FormClosing += Form1_FormClosing;
    }
    
    private  void Form1_Load(object sender, EventArgs e)
    {
        LoadData();
        UpdateSupplierComboBox();   
        UpdateFilmComboBox();
        UpdateCinemaComboBox();
    }
    
   
    
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        SaveData();
    }
    private async void LoadData()
    {
        var data = await FileManagement.GetFromFileAsync();
        
        foreach (var vendor in data.Vendors)
        {
            
            _vendorService.AddVendor(vendor);
        }
        
        foreach (var film in data.Films)
        {
            _filmService.AddFilm(film);
        }
        foreach (var cinema in data.Cinemas)
        {
            _cinemaService.AddCinema(cinema);
        }
        foreach (var rent in data.Rents)
        {
            _rentService.AddRent(rent);
        }
        Console.WriteLine("Data loaded");
        
    }

    private async void SaveData()
    {
        var data = new DataContainer
        {
            Vendors = _vendorService.GetVendors(),
            Films = _filmService.GetFilms(),
            Cinemas = _cinemaService.GetCinemas(),
            Rents = _rentService.GetRents()
        };
        await FileManagement.SaveToFileAsync(data);
    }
    
    private void OpenVendorPanelPanelButtonClick(object sender, EventArgs e)
    {
        foreach (Control control in Controls)
        {
            control.Visible = false;
        }
        addVendorPanel.Visible = true;
        
    }

    private void OpenFilmPanelPanelButtonClick(object sender, EventArgs e)
    {
        foreach (Control control in Controls)
        {
            control.Visible = false;
        }
        addFilmPanel.Visible = true;
        UpdateSupplierComboBox();   
    }
    
    private void OpenCinemaPanelPanelButtonClick(object sender, EventArgs e)
    {
        foreach (Control control in Controls)
        {
            control.Visible = false;
        }
        addCinemaPanel.Visible = true;
    }
    
    private void OpenRentPanelPanelButtonClick(object sender, EventArgs e)
    {
        foreach (Control control in Controls)
        {
            control.Visible = false;
        }
        addRentPanel.Visible = true;   
        UpdateFilmComboBox();
        UpdateCinemaComboBox();
    }
    
    private void backButton_Click(object sender, EventArgs e)
    {
        addVendorPanel.Visible = false;
        addFilmPanel.Visible = false;
        addCinemaPanel.Visible = false; 
        addRentPanel.Visible = false;
        foreach (Control control in Controls)
        {
            if (control != addFilmPanel & control != addVendorPanel & control != addCinemaPanel & control != addRentPanel)
                control.Visible = true;
        }   
    }

    private void AddVendorButtonClick(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(vendorNameTextBox.Text) ||
            string.IsNullOrWhiteSpace(vendorLegalAddressTextBox.Text) ||
            string.IsNullOrWhiteSpace(vendorBankTextBox.Text) ||
            string.IsNullOrWhiteSpace(vendorBankAccountTextBox.Text) ||
            string.IsNullOrWhiteSpace(vendorINNTextBox.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        string name = vendorNameTextBox.Text;
        string legalAddress = vendorLegalAddressTextBox.Text;
        string bank = vendorBankTextBox.Text;
        string bankAccountNumber = vendorBankAccountTextBox.Text;
        string inn = vendorINNTextBox.Text;
        
        string errorMessage = _vendorService.ValidateVendor(name, legalAddress, bank, bankAccountNumber, inn);
        if (!string.IsNullOrEmpty(errorMessage))
        {
            MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        _vendorService.CreateVendor(name, legalAddress, bank, bankAccountNumber, inn);
        MessageBox.Show("Поставщик киноленты успешно добавлен.");

        UpdateSupplierComboBox();
        vendorNameTextBox.Clear();
        vendorLegalAddressTextBox.Clear();
        vendorBankTextBox.Clear();
        vendorBankAccountTextBox.Clear();
        vendorINNTextBox.Clear();
    }
    private void AddFilmButtonClick(object sender, EventArgs e) 
    {
        
        if (string.IsNullOrWhiteSpace(filmNameTextBox.Text) ||
            string.IsNullOrWhiteSpace(filmCategoryTextBox.Text) ||
            string.IsNullOrWhiteSpace(filmScriptwriterTextBox.Text) ||
            string.IsNullOrWhiteSpace(filmProductionDirectorTextBox.Text) ||
            string.IsNullOrWhiteSpace(filmProductionCompanyTextBox.Text) ||
            string.IsNullOrWhiteSpace(filmReleaseYearTextBox.Text) ||
            string.IsNullOrWhiteSpace(filmCostTextBox.Text) ||
            vendorComboBox.SelectedItem == null)
        {
            MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        string name = filmNameTextBox.Text;
        string category = filmCategoryTextBox.Text;
        string scriptwriter = filmScriptwriterTextBox.Text;
        string productiondirector = filmProductionDirectorTextBox.Text;
        string productionCompany = filmProductionCompanyTextBox.Text;
        string releaseYearText = filmReleaseYearTextBox.Text;
        string costText = filmCostTextBox.Text;
        Vendor selectedVendor = vendorComboBox.SelectedItem as Vendor;

        string errorMessage = _filmService.ValidateFilm(name, category, scriptwriter, productiondirector, productionCompany, releaseYearText, costText);
        if (!string.IsNullOrEmpty(errorMessage))
        {
            MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (selectedVendor == null)
        {
            MessageBox.Show("Пожалуйста, выберите поставщика или добавьте его сначала с помощью кнопки 'Добавить поставщика'.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        int releaseYear = int.Parse(releaseYearText);
        decimal cost = decimal.Parse(costText);
        
        
        var film = _filmService.CreateFilm(name, category, scriptwriter, productiondirector, productionCompany, releaseYear, cost);
        _vendorService.AddFilmToVendor(selectedVendor, film);
        
        MessageBox.Show("Фильм успешно добавлен.");
        
        UpdateFilmComboBox();
        filmNameTextBox.Clear();
        filmCategoryTextBox.Clear();
        filmScriptwriterTextBox.Clear();
        filmProductionDirectorTextBox.Clear();
        filmProductionCompanyTextBox.Clear();
        filmReleaseYearTextBox.Clear();
        filmCostTextBox.Clear();
        vendorComboBox.SelectedIndex = -1;
    }
    private void AddCinemaButtonClick(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(cinemaNameTextBox.Text) ||
            string.IsNullOrWhiteSpace(cinemaAddressTextBox.Text) ||
            string.IsNullOrWhiteSpace(cinemaPhoneTextBox.Text) ||
            string.IsNullOrWhiteSpace(cinemaSeatCapacityTextBox.Text) ||
            string.IsNullOrWhiteSpace(cinemaDirectorTextBox.Text) ||
            string.IsNullOrWhiteSpace(cinemaOwnerTextBox.Text) ||
            string.IsNullOrWhiteSpace(cinemaBankNameTextBox.Text) ||
            string.IsNullOrWhiteSpace(cinemaBankAccountTextBox.Text) ||
            string.IsNullOrWhiteSpace(cinemaInnTextBox.Text) )
        {
            MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        string name = cinemaNameTextBox.Text;
        string address = cinemaAddressTextBox.Text;
        string phone = cinemaPhoneTextBox.Text;
        string seatCapacityText = cinemaSeatCapacityTextBox.Text;
        string director = cinemaDirectorTextBox.Text;
        string owner = cinemaOwnerTextBox.Text;
        string bankName = cinemaBankNameTextBox.Text;
        string bankAccount = cinemaBankAccountTextBox.Text;
        string inn = cinemaInnTextBox.Text;
        
        string errorMessage = _cinemaService.ValidateCinema(name, address, phone, seatCapacityText, director, owner, bankName, bankAccount, inn);
        if (!string.IsNullOrEmpty(errorMessage))
        {
            MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        int seatCapacity = int.Parse(seatCapacityText);  
        _cinemaService.CreateCinema(name, address, phone, seatCapacity, director, owner, bankName, bankAccount, inn);
        MessageBox.Show("Кинотеатр успешно добавлен.");
        
        UpdateCinemaComboBox();
        cinemaNameTextBox.Clear();
        cinemaAddressTextBox.Clear();
        cinemaPhoneTextBox.Clear();
        cinemaSeatCapacityTextBox.Clear();
        cinemaDirectorTextBox.Clear();
        cinemaOwnerTextBox.Clear();
        cinemaBankNameTextBox.Clear();
        cinemaBankAccountTextBox.Clear();
        cinemaInnTextBox.Clear();
    }
    
    private void AddRentButtonClick (object sender, EventArgs e)
    {
        if (cinemaNameRentComboBox.SelectedItem == null ||
            filmRentComboBox.SelectedItem == null ||
            startDateRentPicker.Value == null ||
            endDateRentPicker.Value == null ||
            string.IsNullOrWhiteSpace(rentalPriceRentTextBox.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        Cinema сinema = cinemaNameRentComboBox.SelectedItem as Cinema;
        Film film = filmRentComboBox.SelectedItem as Film;
        DateTime startDate = startDateRentPicker.Value;
        DateTime endDate = endDateRentPicker.Value;
        string rentalPriceText = rentalPriceRentTextBox.Text;
        
        if (!decimal.TryParse(rentalPriceText, out var rentalPrice) || !RentValidator.ValidateRentalPrice(rentalPrice) )
        {
            MessageBox.Show("Введите корректную цену аренды, она должна быть больше 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (endDate <= startDate)
        {
            MessageBox.Show("Дата окончания аренды не может быть раньше даты начала.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        _rentService.CreateRent(сinema, film, startDate, endDate, rentalPrice);
        MessageBox.Show("Аренда успешно добавлена.");
        
        cinemaNameRentComboBox.SelectedIndex = -1;
        filmRentComboBox.SelectedIndex = -1;
        startDateRentPicker.Value = DateTime.Now;
        endDateRentPicker.Value = DateTime.Now;
        rentalPriceRentTextBox.Clear();
    }
    private void UpdateSupplierComboBox()
    {
        vendorComboBox.Items.Clear(); 
        var vendors = _vendorService.GetVendors(); 
        foreach (var vendor in vendors)
        {
            vendorComboBox.Items.Add(vendor); 
        }
        vendorComboBox.DisplayMember = "Name"; 
    }
    private void UpdateFilmComboBox()
    {
        filmRentComboBox.Items.Clear(); 
        var films = _filmService.GetFilms(); 
        foreach (var film in films)
        {
            filmRentComboBox.Items.Add(film); 
        }
        filmRentComboBox.DisplayMember = "Name"; 
    }
    private void UpdateCinemaComboBox()
    {
        cinemaNameRentComboBox.Items.Clear(); 
        var cinemas = _cinemaService.GetCinemas(); 
        foreach (var cinema in cinemas)
        {
            cinemaNameRentComboBox.Items.Add(cinema); 
        }
        cinemaNameRentComboBox.DisplayMember = "Name";
    }
    
    private void ShowRentFormButton_Click(object sender, EventArgs e)
    {
        ShowRentsForm showRentsForm = new ShowRentsForm(_rentService);
        showRentsForm.Show();
    }


    private void ShowVendorFormButton_Click(object sender, EventArgs e)
    {
        ShowVendorsForm showVendorsForm = new ShowVendorsForm(_vendorService);
        showVendorsForm.Show();
    }
    
    private void ShowCinemaFormButton_Click(object sender, EventArgs e)
    {
        ShowCinemasForm showCinemasForm = new ShowCinemasForm(_cinemaService);
        showCinemasForm.Show();
    }
    private void ShowFilmFormButton_Click(object sender, EventArgs e)
    {
        ShowFilmsForm showFilmsForm = new ShowFilmsForm(_filmService);
        showFilmsForm.Show();
    }
    
}