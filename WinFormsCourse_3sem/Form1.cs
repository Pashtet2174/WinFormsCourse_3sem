using Course_3sem;

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
            MessageBox.Show("Все поля должны быть заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        string name = vendorNameTextBox.Text;
        string legalAddress = vendorLegalAddressTextBox.Text;
        string bank = vendorBankTextBox.Text;
        string bankAccount = vendorBankAccountTextBox.Text;
        string inn = vendorINNTextBox.Text;
        
        Vendor vendor = new Vendor(name, legalAddress, bank, bankAccount, inn);
        _vendorService.AddVendor(vendor);
        MessageBox.Show($"Поставщик успешно добавлен.");
        
        UpdateSupplierComboBox();
        vendorNameTextBox.Clear();
        vendorLegalAddressTextBox.Clear();
        vendorBankTextBox.Clear();
        vendorBankAccountTextBox.Clear();
        vendorINNTextBox.Clear();
    }
    
    private void AddFilmButtonClick (object sender, EventArgs e)
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

        // Получение данных из текстовых полей
        string title = filmNameTextBox.Text;
        string category = filmCategoryTextBox.Text;
        string screenwriter = filmScriptwriterTextBox.Text;
        string director = filmProductionDirectorTextBox.Text;
        string producerCompany = filmProductionCompanyTextBox.Text;

        // Преобразование года выпуска и стоимости
        if (!int.TryParse(filmReleaseYearTextBox.Text, out int releaseYear))
        {
            MessageBox.Show("Введите корректный год выпуска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!decimal.TryParse(filmCostTextBox.Text, out decimal purchaseCost))
        {
            MessageBox.Show("Введите корректную стоимость.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Получение выбранного поставщика
        Vendor selectedVendor = vendorComboBox.SelectedItem as Vendor;

        if (selectedVendor == null)
        {
            MessageBox.Show("Пожалуйста, выберите поставщика.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Создание объекта Film
        Film film = new Film(title, category, screenwriter, director, producerCompany, releaseYear, purchaseCost, selectedVendor);
    
        // Добавление фильма через сервисы
        _filmService.AddFilm(film);
        _vendorService.AddFilmToVendor(selectedVendor, film);

        // Уведомление об успешном добавлении
        MessageBox.Show($"Фильм успешно добавлен.");

        // Очистка полей
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
        
    }
    
    private void AddRentButtonClick (object sender, EventArgs e)
    {
        
    }

    private void saveAndBackButton_Click (object sender, EventArgs e)
    {
        
    }
    
    
    
    
    private void OpenShowRentsForm()
    {
        // Создание и отображение формы AddVendorForm с передачей сервисов
        ShowRentsForm showRentsForm = new ShowRentsForm(_cinemaService, _filmService, _vendorService, _rentService);
        showRentsForm.Show();
    }
    
    private void ShowRentFormButton_Click(object sender, EventArgs e)
    {
        // Создание и отображение формы AddVendorForm с передачей сервисов
        ShowRentsForm showRentsForm = new ShowRentsForm(_cinemaService, _filmService, _vendorService, _rentService);
        showRentsForm.Show();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        UpdateSupplierComboBox();
    }
    
    private void UpdateSupplierComboBox()
    {
        vendorComboBox.Items.Clear(); // Очищаем старые элементы
        var vendors = _vendorService.GetVendors(); // Получаем список поставщиков
        foreach (var vendor in vendors)
        {
            vendorComboBox.Items.Add(vendor); // Добавляем каждого поставщика
        }
        vendorComboBox.DisplayMember = "Name"; // Указываем, что отображать в списке
    }
    
    private void CinemaTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Clear the additional field when the selection changes
        additionalLabel.Text = string.Empty;
        additionalTextBox.Clear();

        switch (cinemaTypeComboBox.SelectedItem.ToString())
        {
            case "Традиционный":
                additionalLabel.Text = "Тип экрана:";
                break;
            case "Под открытым небом":
                additionalLabel.Text = "Ёмкость парковки:";
                break;
            case "4D":
                additionalLabel.Text = "Эффектные сиденья:";
                break;
        }

        // Show the additional field
        additionalLabel.Visible = true;
        additionalTextBox.Visible = true;
    }

    
}