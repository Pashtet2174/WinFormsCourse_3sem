namespace WinFormsCourse_3sem;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        openVendorPanelButton = new System.Windows.Forms.Button();
        openFilmPanelButton = new System.Windows.Forms.Button();
        openCinemaPanelButton = new System.Windows.Forms.Button();
        openRentPanelButton = new System.Windows.Forms.Button();
        ShowRentsButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // openVendorPanelButton
        // 
        openVendorPanelButton.Location = new System.Drawing.Point(50, 77);
        openVendorPanelButton.Name = "openVendorPanelButton";
        openVendorPanelButton.Size = new System.Drawing.Size(150, 101);
        openVendorPanelButton.TabIndex = 0;
        openVendorPanelButton.Text = "Добавить поставщика";
        openVendorPanelButton.UseVisualStyleBackColor = true;
        openVendorPanelButton.Click += OpenVendorPanelPanelButtonClick;
        // 
        // openFilmPanelButton
        // 
        openFilmPanelButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
        openFilmPanelButton.Location = new System.Drawing.Point(305, 77);
        openFilmPanelButton.Name = "openFilmPanelButton";
        openFilmPanelButton.Size = new System.Drawing.Size(150, 101);
        openFilmPanelButton.TabIndex = 1;
        openFilmPanelButton.Text = "Добавить фильм";
        openFilmPanelButton.UseVisualStyleBackColor = true;
        openFilmPanelButton.Click += OpenFilmPanelPanelButtonClick;
        // 
        // openCinemaPanelButton
        // 
        openCinemaPanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        openCinemaPanelButton.Location = new System.Drawing.Point(557, 77);
        openCinemaPanelButton.Name = "openCinemaPanelButton";
        openCinemaPanelButton.Size = new System.Drawing.Size(150, 101);
        openCinemaPanelButton.TabIndex = 2;
        openCinemaPanelButton.Text = "Добавить кинотеатр";
        openCinemaPanelButton.UseVisualStyleBackColor = true;
        openCinemaPanelButton.Click += OpenCinemaPanelPanelButtonClick;
        // 
        // openRentPanelButton
        // 
        openRentPanelButton.Location = new System.Drawing.Point(50, 540);
        openRentPanelButton.Name = "openRentPanelButton";
        openRentPanelButton.Size = new System.Drawing.Size(150, 101);
        openRentPanelButton.TabIndex = 3;
        openRentPanelButton.Text = "Добавить аренду";
        openRentPanelButton.UseVisualStyleBackColor = true;
        openRentPanelButton.Click += OpenRentPanelPanelButtonClick;
        // 
        // ShowRentsButton
        // 
        ShowRentsButton.Location = new System.Drawing.Point(557, 540);
        ShowRentsButton.Name = "ShowRentsButton";
        ShowRentsButton.Size = new System.Drawing.Size(150, 101);
        ShowRentsButton.TabIndex = 4;
        ShowRentsButton.Text = "Показать список аренды";
        ShowRentsButton.UseVisualStyleBackColor = true;
        ShowRentsButton.Click += ShowRentFormButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ControlLight;
        ClientSize = new System.Drawing.Size(823, 753);
        Controls.Add(ShowRentsButton);
        Controls.Add(openRentPanelButton);
        Controls.Add(openCinemaPanelButton);
        Controls.Add(openFilmPanelButton);
        Controls.Add(openVendorPanelButton);
        Text = "Система учёта аренды кинофильмов";
        Location = new System.Drawing.Point(19, 19);
        MinimumSize = new System.Drawing.Size(800, 800);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button ShowRentsButton;
    private System.Windows.Forms.Button openRentPanelButton;
    private System.Windows.Forms.Button openCinemaPanelButton;
    private System.Windows.Forms.Button openFilmPanelButton;
    private System.Windows.Forms.Button openVendorPanelButton;
    
    private System.Windows.Forms.Panel addVendorPanel;
    private System.Windows.Forms.TextBox vendorNameTextBox;
    private System.Windows.Forms.TextBox vendorLegalAddressTextBox;
    private System.Windows.Forms.Button backButton;
    private System.Windows.Forms.Button addVendorButton;
    private System.Windows.Forms.Label vendorNameLabel;
    private System.Windows.Forms.TextBox vendorBankTextBox;
    private System.Windows.Forms.Label vendorBankLabel;
    private System.Windows.Forms.Label vendorLegalAddressLabel;
    private System.Windows.Forms.Label vendorBankAccountLabel;
    private System.Windows.Forms.TextBox vendorBankAccountTextBox;
    private System.Windows.Forms.Label vendorINNLabel;
    private System.Windows.Forms.TextBox vendorINNTextBox;
    private System.Windows.Forms.Button saveAndBackButton;
    private void InitializeAddVendorPanel()
    {
        addVendorPanel = new System.Windows.Forms.Panel();
        vendorNameLabel = new Label();
        vendorNameTextBox = new System.Windows.Forms.TextBox();
        vendorLegalAddressLabel = new Label();
        vendorLegalAddressTextBox = new System.Windows.Forms.TextBox();
        vendorBankLabel = new Label();
        vendorBankTextBox = new TextBox();
        vendorBankAccountLabel = new Label();
        vendorBankAccountTextBox = new TextBox();
        vendorINNLabel = new Label();
        vendorINNTextBox = new TextBox();
        backButton = new System.Windows.Forms.Button();
        addVendorButton = new System.Windows.Forms.Button();
        saveAndBackButton = new System.Windows.Forms.Button();
        
        SuspendLayout();
        //
        // addVendorPanel
        //
        addVendorPanel.Controls.Add(vendorNameLabel);
        addVendorPanel.Controls.Add(vendorNameTextBox);
        addVendorPanel.Controls.Add(vendorLegalAddressLabel);
        addVendorPanel.Controls.Add(vendorLegalAddressTextBox);
        addVendorPanel.Controls.Add(vendorBankLabel);
        addVendorPanel.Controls.Add(vendorBankTextBox);
        addVendorPanel.Controls.Add(vendorBankAccountLabel);
        addVendorPanel.Controls.Add(vendorBankAccountTextBox);
        addVendorPanel.Controls.Add(vendorINNLabel);
        addVendorPanel.Controls.Add(vendorINNTextBox);
        addVendorPanel.Controls.Add(backButton);
        addVendorPanel.Controls.Add(addVendorButton); 
        addVendorPanel.Controls.Add(saveAndBackButton); 
        addVendorPanel.Name = "addVendorPanel";
        addVendorPanel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
        addVendorPanel.Dock = DockStyle.Fill;
        addVendorPanel.TabIndex = 1; 
        addVendorPanel.Visible = false;
        //
        // vendorNameLabel
        //
        vendorNameLabel.Location = new System.Drawing.Point(20, 20); 
        vendorNameLabel.Name = "vendorNameLabel";
        vendorNameLabel.Text = "Поставщик киноленты";
        vendorNameLabel.Size = new System.Drawing.Size(300, 27); 
        vendorNameLabel.TabIndex = 0;
        //
        // vendorNameTextBox
        //
        vendorNameTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        vendorNameTextBox.Location = new System.Drawing.Point(20, 50); 
        vendorNameTextBox.Name = "vendorNameTextBox"; 
        vendorNameTextBox.Size = new System.Drawing.Size(300, 27); 
        vendorNameTextBox.TabIndex = 1;
        //
        // vendorLegalAddressLabel
        //
        vendorLegalAddressLabel.Location = new System.Drawing.Point(20, 80); 
        vendorLegalAddressLabel.Name = "vendorLegalAddressLabel";
        vendorLegalAddressLabel.Text = "Юридический адресс";
        vendorLegalAddressLabel.Size = new System.Drawing.Size(300, 27); 
        vendorLegalAddressLabel.TabIndex = 2;
        //
        // vendorLegalAddressTextBox
        //
        vendorLegalAddressTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        vendorLegalAddressTextBox.Location = new System.Drawing.Point(20, 110); 
        vendorLegalAddressTextBox.Name = "vendorLegalAddressTextBox"; 
        vendorLegalAddressTextBox.Size = new System.Drawing.Size(300, 27); 
        vendorLegalAddressTextBox.TabIndex = 3;
        //
        // vendorBankLabel
        //
        vendorBankLabel.Location = new System.Drawing.Point(20, 140); 
        vendorBankLabel.Name = "vendorBankLabel";
        vendorBankLabel.Text = "Банк";
        vendorBankLabel.Size = new System.Drawing.Size(300, 27); 
        vendorBankLabel.TabIndex = 4;
        //
        // vendorBankTextBox
        //
        vendorBankTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        vendorBankTextBox.Location = new System.Drawing.Point(20, 170); 
        vendorBankTextBox.Name = "vendorBankTextBox"; 
        vendorBankTextBox.Size = new System.Drawing.Size(300, 27); 
        vendorBankTextBox.TabIndex = 5;
        //
        // vendorBankAccountLabel
        //
        vendorBankAccountLabel.Location = new System.Drawing.Point(20, 200); 
        vendorBankAccountLabel.Name = "vendorBankAccountLabel";
        vendorBankAccountLabel.Text = "Номер счёта";
        vendorBankAccountLabel.Size = new System.Drawing.Size(300, 27); 
        vendorBankAccountLabel.TabIndex = 6;
        //
        // vendorBankAccountTextBox
        //
        vendorBankAccountTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        vendorBankAccountTextBox.Location = new System.Drawing.Point(20, 230); 
        vendorBankAccountTextBox.Name = "vendorBankAccountTextBox"; 
        vendorBankAccountTextBox.Size = new System.Drawing.Size(300, 27); 
        vendorBankAccountTextBox.TabIndex = 7;
        //
        // vendorINNLabel
        //
        vendorINNLabel.Location = new System.Drawing.Point(20, 260); 
        vendorINNLabel.Name = "vendorINNLabel";
        vendorINNLabel.Text = "ИНН";
        vendorINNLabel.Size = new System.Drawing.Size(300, 27); 
        vendorINNLabel.TabIndex = 8;
        //
        // vendorINNTextBox
        //
        vendorINNTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        vendorINNTextBox.Location = new System.Drawing.Point(20, 290); 
        vendorINNTextBox.Name = "vendorINNTextBox"; 
        vendorINNTextBox.Size = new System.Drawing.Size(300, 27); 
        vendorINNTextBox.TabIndex = 9;
        //
        // backButton
        //
        backButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
        backButton.Location = new System.Drawing.Point(20, 350);
        backButton.Name = "backButton"; 
        backButton.Size = new System.Drawing.Size(120, 70);
        backButton.TabIndex = 2; 
        backButton.Text = "Назад"; 
        backButton.UseVisualStyleBackColor = true; 
        backButton.Click += backButton_Click;
        //
        // addVendorButton
        //
        addVendorButton.Anchor = (AnchorStyles.Bottom);
        addVendorButton.Location = new System.Drawing.Point(50, 350); 
        addVendorButton.Name = "addVendorButton"; 
        addVendorButton.Size = new System.Drawing.Size(120, 70);
        addVendorButton.TabIndex = 3; 
        addVendorButton.Text = "Добавить"; 
        addVendorButton.UseVisualStyleBackColor = true; 
        addVendorButton.Click += AddVendorButtonClick;
        //
        //saveAndBackButton
        //
        saveAndBackButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
        saveAndBackButton.Location = new System.Drawing.Point(90, 350); 
        saveAndBackButton.Name = "saveVendorButton"; 
        saveAndBackButton.Size = new System.Drawing.Size(120, 70);
        saveAndBackButton.TabIndex = 4; 
        saveAndBackButton.Text = "Сохранить данные и выйти"; 
        saveAndBackButton.UseVisualStyleBackColor = true; 
        saveAndBackButton.Click += saveAndBackButton_Click;
        
        Controls.Add(addVendorPanel);
        ResumeLayout(false);
    }

    
    private System.Windows.Forms.Panel addFilmPanel;
    private System.Windows.Forms.TextBox filmNameTextBox;
    private System.Windows.Forms.TextBox filmCategoryTextBox;
    private System.Windows.Forms.TextBox filmScriptwriterTextBox;
    private System.Windows.Forms.TextBox filmProductionDirectorTextBox;
    private System.Windows.Forms.TextBox filmProductionCompanyTextBox;
    private System.Windows.Forms.TextBox filmReleaseYearTextBox;
    private System.Windows.Forms.TextBox filmCostTextBox;
    private System.Windows.Forms.ComboBox vendorComboBox;
    private System.Windows.Forms.Label filmNameLabel;
    private System.Windows.Forms.Label filmCategoryLabel;
    private System.Windows.Forms.Label filmScriptwriterLabel;
    private System.Windows.Forms.Label filmProductionDirectorLabel;
    private System.Windows.Forms.Label filmProductionCompanyLabel;
    private System.Windows.Forms.Label filmReleaseYearLabel;
    private System.Windows.Forms.Label filmCostLabel;
    private System.Windows.Forms.Label vendorLabel;
    private System.Windows.Forms.Button addFilmButton;
    private System.Windows.Forms.Button back2Button;
    //private System.Windows.Forms.Button saveAndBackButton;

    private void InitializeAddFilmPanel()
    {
        addFilmPanel = new System.Windows.Forms.Panel();
        filmNameLabel = new Label();
        filmNameTextBox = new System.Windows.Forms.TextBox();
        filmCategoryLabel = new Label();
        filmCategoryTextBox = new System.Windows.Forms.TextBox();
        filmScriptwriterLabel = new Label();
        filmScriptwriterTextBox = new System.Windows.Forms.TextBox();
        filmProductionDirectorLabel = new Label();
        filmProductionDirectorTextBox = new System.Windows.Forms.TextBox();
        filmProductionCompanyLabel = new Label();
        filmProductionCompanyTextBox = new System.Windows.Forms.TextBox();
        filmReleaseYearLabel = new Label();
        filmReleaseYearTextBox = new System.Windows.Forms.TextBox();
        filmCostLabel = new Label();
        filmCostTextBox = new System.Windows.Forms.TextBox();
        vendorLabel = new Label();
        vendorComboBox = new ComboBox();
        back2Button = new System.Windows.Forms.Button();
        addFilmButton = new System.Windows.Forms.Button();
        //saveAndBackButton = new System.Windows.Forms.Button();

        SuspendLayout();
        //
        // addFilmPanel
        //
        addFilmPanel.Controls.Add(filmNameLabel);
        addFilmPanel.Controls.Add(filmNameTextBox);
        addFilmPanel.Controls.Add(filmCategoryLabel);
        addFilmPanel.Controls.Add(filmCategoryTextBox);
        addFilmPanel.Controls.Add(filmScriptwriterLabel);
        addFilmPanel.Controls.Add(filmScriptwriterTextBox);
        addFilmPanel.Controls.Add(filmProductionDirectorLabel);
        addFilmPanel.Controls.Add(filmProductionDirectorTextBox);
        addFilmPanel.Controls.Add(filmProductionCompanyLabel);
        addFilmPanel.Controls.Add(filmProductionCompanyTextBox);
        addFilmPanel.Controls.Add(filmReleaseYearLabel);
        addFilmPanel.Controls.Add(filmReleaseYearTextBox);
        addFilmPanel.Controls.Add(filmCostLabel);
        addFilmPanel.Controls.Add(filmCostTextBox);
        addFilmPanel.Controls.Add(vendorLabel);
        addFilmPanel.Controls.Add(vendorComboBox);
        addFilmPanel.Controls.Add(back2Button);
        addFilmPanel.Controls.Add(addFilmButton);
        //addFilmPanel.Controls.Add(saveAndBackButton);
        addFilmPanel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
        addFilmPanel.Name = "addFilmPanel";
        addFilmPanel.Dock = DockStyle.Fill;
        addFilmPanel.TabIndex = 1;
        addFilmPanel.Visible = false;
        //
        // filmNameLabel
        //
        filmNameLabel.Location = new System.Drawing.Point(20, 20);
        filmNameLabel.Name = "filmNameLabel";
        filmNameLabel.Text = "Название кинофильма";
        filmNameLabel.Size = new System.Drawing.Size(300, 27);
        filmNameLabel.TabIndex = 0;
        //
        // filmNameTextBox
        //
        filmNameTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        filmNameTextBox.Location = new System.Drawing.Point(20, 50);
        filmNameTextBox.Name = "filmNameTextBox";
        filmNameTextBox.Size = new System.Drawing.Size(300, 27);
        filmNameTextBox.TabIndex = 1;
        //
        // filmCategoryLabel
        //
        filmCategoryLabel.Location = new System.Drawing.Point(20, 80);
        filmCategoryLabel.Name = "filmCategoryLabel";
        filmCategoryLabel.Text = "Категория";
        filmCategoryLabel.Size = new System.Drawing.Size(300, 27);
        filmCategoryLabel.TabIndex = 2;
        //
        // filmCategoryTextBox
        //
        filmCategoryTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        filmCategoryTextBox.Location = new System.Drawing.Point(20, 110);
        filmCategoryTextBox.Name = "filmCategoryTextBox";
        filmCategoryTextBox.Size = new System.Drawing.Size(300, 27);
        filmCategoryTextBox.TabIndex = 3;
        //
        // filmScriptwriterLabel
        //
        filmScriptwriterLabel.Location = new System.Drawing.Point(20, 140);
        filmScriptwriterLabel.Name = "filmScriptwriterLabel";
        filmScriptwriterLabel.Text = "Автор сценария";
        filmScriptwriterLabel.Size = new System.Drawing.Size(300, 27);
        filmScriptwriterLabel.TabIndex = 4;
        //
        // filmScriptwriterTextBox
        //
        filmScriptwriterTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        filmScriptwriterTextBox.Location = new System.Drawing.Point(20, 170);
        filmScriptwriterTextBox.Name = "filmScriptwriterTextBox";
        filmScriptwriterTextBox.Size = new System.Drawing.Size(300, 27);
        filmScriptwriterTextBox.TabIndex = 5;
        //
        // filmProductionDirectorLabel
        //
        filmProductionDirectorLabel.Location = new System.Drawing.Point(20, 200);
        filmProductionDirectorLabel.Name = "filmProductionDirectorLabel";
        filmProductionDirectorLabel.Text = "Режиссёр-постановщик";
        filmProductionDirectorLabel.Size = new System.Drawing.Size(300, 27);
        filmProductionDirectorLabel.TabIndex = 6;
        //
        // filmProductionDirectorTextBox
        //
        filmProductionDirectorTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        filmProductionDirectorTextBox.Location = new System.Drawing.Point(20, 230);
        filmProductionDirectorTextBox.Name = "filmProductionDirectorTextBox";
        filmProductionDirectorTextBox.Size = new System.Drawing.Size(300, 27);
        filmProductionDirectorTextBox.TabIndex = 7;
        //
        // filmProductionCompanyLabel
        //
        filmProductionCompanyLabel.Location = new System.Drawing.Point(20, 260);
        filmProductionCompanyLabel.Name = "filmProductionCompanyLabel";
        filmProductionCompanyLabel.Text = "Компания-производитель";
        filmProductionCompanyLabel.Size = new System.Drawing.Size(300, 27);
        filmProductionCompanyLabel.TabIndex = 8;
        //
        // filmProductionCompanyTextBox
        //
        filmProductionCompanyTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        filmProductionCompanyTextBox.Location = new System.Drawing.Point(20, 290);
        filmProductionCompanyTextBox.Name = "filmProductionCompanyTextBox";
        filmProductionCompanyTextBox.Size = new System.Drawing.Size(300, 27);
        filmProductionCompanyTextBox.TabIndex = 9;
        //
        // filmReleaseYearLabel
        //
        filmReleaseYearLabel.Location = new System.Drawing.Point(20, 320);
        filmReleaseYearLabel.Name = "filmReleaseYearLabel";
        filmReleaseYearLabel.Text = "Год выхода на экран";
        filmReleaseYearLabel.Size = new System.Drawing.Size(300, 27);
        filmReleaseYearLabel.TabIndex = 10;
        //
        // filmReleaseYearTextBox
        //
        filmReleaseYearTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        filmReleaseYearTextBox.Location = new System.Drawing.Point(20, 350);
        filmReleaseYearTextBox.Name = "filmReleaseYearTextBox";
        filmReleaseYearTextBox.Size = new System.Drawing.Size(300, 27);
        filmReleaseYearTextBox.TabIndex = 11;
        //
        // filmCostLabel
        //
        filmCostLabel.Location = new System.Drawing.Point(20, 380);
        filmCostLabel.Name = "filmCostLabel";
        filmCostLabel.Text = "Стоимость приобретения";
        filmCostLabel.Size = new System.Drawing.Size(300, 27);
        filmCostLabel.TabIndex = 12;
        //
        // filmCostTextBox
        //
        filmCostTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        filmCostTextBox.Location = new System.Drawing.Point(20, 410);
        filmCostTextBox.Name = "filmCostTextBox";
        filmCostTextBox.Size = new System.Drawing.Size(300, 27);
        filmCostTextBox.TabIndex = 13;
        //
        // supplierLabel
        //
        vendorLabel.Location = new System.Drawing.Point(20, 440);
        vendorLabel.Name = "vendorLabel";
        vendorLabel.Text = "Поставщик киноленты";
        vendorLabel.Size = new System.Drawing.Size(300, 27);
        vendorLabel.TabIndex = 14;
        //
        // supplierComboBox
        //
        vendorComboBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        vendorComboBox.Location = new System.Drawing.Point(20, 470);
        vendorComboBox.Name = "vendorComboBox";
        vendorComboBox.Size = new System.Drawing.Size(300, 27);
        vendorComboBox.TabIndex = 15;
        //
        // back2Button
        //
        back2Button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
        back2Button.Location = new System.Drawing.Point(20, 530);
        back2Button.Name = "back2Button";
        back2Button.Size = new System.Drawing.Size(120, 70);
        back2Button.TabIndex = 16;
        back2Button.Text = "Назад";
        back2Button.UseVisualStyleBackColor = true;
        back2Button.Click += backButton_Click;
        //
        // addFilmButton
        //
        addFilmButton.Anchor = (AnchorStyles.Bottom);
        addFilmButton.Location = new System.Drawing.Point(50, 510);
        addFilmButton.Name = "addFilmButton";
        addFilmButton.Size = new System.Drawing.Size(120, 70);
        addFilmButton.TabIndex = 17;
        addFilmButton.Text = "Добавить";
        addFilmButton.UseVisualStyleBackColor = true;
        addFilmButton.Click += AddFilmButtonClick;

        Controls.Add(addFilmPanel);
        ResumeLayout(false);
    }
    
    private System.Windows.Forms.Panel addCinemaPanel;
    private System.Windows.Forms.TextBox cinemaNameTextBox;
    private System.Windows.Forms.TextBox cinemaAddressTextBox;
    private System.Windows.Forms.TextBox cinemaPhoneTextBox;
    private System.Windows.Forms.TextBox cinemaSeatCapacityTextBox;
    private System.Windows.Forms.TextBox cinemaDirectorTextBox;
    private System.Windows.Forms.TextBox cinemaOwnerTextBox;
    private System.Windows.Forms.TextBox cinemaBankNameTextBox;
    private System.Windows.Forms.TextBox cinemaBankAccountTextBox;
    private System.Windows.Forms.TextBox cinemaInnTextBox;
    private System.Windows.Forms.Button back3Button;
    private System.Windows.Forms.Button addCinemaButton;
    private System.Windows.Forms.Label cinemaNameLabel;
    private System.Windows.Forms.Label cinemaAddressLabel;
    private System.Windows.Forms.Label cinemaPhoneLabel;
    private System.Windows.Forms.Label cinemaSeatCapacityLabel;
    private System.Windows.Forms.Label cinemaDirectorLabel;
    private System.Windows.Forms.Label cinemaOwnerLabel;
    private System.Windows.Forms.Label cinemaBankNameLabel;
    private System.Windows.Forms.Label cinemaBankAccountLabel;
    private System.Windows.Forms.Label cinemaInnLabel;
    private System.Windows.Forms.ComboBox cinemaTypeComboBox;
    private System.Windows.Forms.Label additionalLabel;
    private System.Windows.Forms.TextBox additionalTextBox;
        

    private void InitializeAddCinemaPanel()
    {
        addCinemaPanel = new System.Windows.Forms.Panel();
        cinemaNameLabel = new Label();
        cinemaNameTextBox = new System.Windows.Forms.TextBox();
        cinemaAddressLabel = new Label();
        cinemaAddressTextBox = new System.Windows.Forms.TextBox();
        cinemaPhoneLabel = new Label();
        cinemaPhoneTextBox = new TextBox();
        cinemaSeatCapacityLabel = new Label();
        cinemaSeatCapacityTextBox = new TextBox();
        cinemaDirectorLabel = new Label();
        cinemaDirectorTextBox = new TextBox();
        cinemaOwnerLabel = new Label();
        cinemaOwnerTextBox = new TextBox();
        cinemaBankNameLabel = new Label();
        cinemaBankNameTextBox = new TextBox();
        cinemaBankAccountLabel = new Label();
        cinemaBankAccountTextBox = new TextBox();
        cinemaInnLabel = new Label();
        cinemaInnTextBox = new TextBox();
        back3Button = new System.Windows.Forms.Button();
        addCinemaButton = new System.Windows.Forms.Button();
        cinemaTypeComboBox = new ComboBox();
        additionalLabel = new Label();
        additionalTextBox = new TextBox();
        cinemaTypeComboBox.Items.Add("Традиционный кинотеатр");
        cinemaTypeComboBox.Items.Add("Кинотеатр под открытым небом");
        cinemaTypeComboBox.Items.Add("4D кинотеатр ");
        cinemaTypeComboBox.SelectedIndexChanged += CinemaTypeComboBox_SelectedIndexChanged;
        
        SuspendLayout();
        // 
        // addCinemaPanel
        // 
        addCinemaPanel.Controls.Add(cinemaTypeComboBox);
        addCinemaPanel.Controls.Add(additionalLabel); 
        addCinemaPanel.Controls.Add(additionalTextBox); 
        addCinemaPanel.Controls.Add(cinemaNameLabel);
        addCinemaPanel.Controls.Add(cinemaNameTextBox);
        addCinemaPanel.Controls.Add(cinemaAddressLabel);
        addCinemaPanel.Controls.Add(cinemaAddressTextBox);
        addCinemaPanel.Controls.Add(cinemaPhoneLabel);
        addCinemaPanel.Controls.Add(cinemaPhoneTextBox);
        addCinemaPanel.Controls.Add(cinemaSeatCapacityLabel);
        addCinemaPanel.Controls.Add(cinemaSeatCapacityTextBox);
        addCinemaPanel.Controls.Add(cinemaDirectorLabel);
        addCinemaPanel.Controls.Add(cinemaDirectorTextBox);
        addCinemaPanel.Controls.Add(cinemaOwnerLabel);
        addCinemaPanel.Controls.Add(cinemaOwnerTextBox);
        addCinemaPanel.Controls.Add(cinemaBankNameLabel);
        addCinemaPanel.Controls.Add(cinemaBankNameTextBox);
        addCinemaPanel.Controls.Add(cinemaBankAccountLabel);
        addCinemaPanel.Controls.Add(cinemaBankAccountTextBox);
        addCinemaPanel.Controls.Add(cinemaInnLabel);
        addCinemaPanel.Controls.Add(cinemaInnTextBox);
        addCinemaPanel.Controls.Add(back3Button);
        addCinemaPanel.Controls.Add(addCinemaButton);
        addCinemaPanel.Name = "addCinemaPanel";
        addCinemaPanel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
        addCinemaPanel.Dock = DockStyle.Fill;
        addCinemaPanel.TabIndex = 1;
        addCinemaPanel.Visible = false;
        // 
        // cinemaNameLabel
        // 
        cinemaNameLabel.Location = new System.Drawing.Point(20, 20);
        cinemaNameLabel.Name = "cinemaNameLabel";
        cinemaNameLabel.Text = "Название кинотеатра";
        cinemaNameLabel.Size = new System.Drawing.Size(300, 27);
        cinemaNameLabel.TabIndex = 0;
        // 
        // cinemaNameTextBox
        // 
        cinemaNameTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        cinemaNameTextBox.Location = new System.Drawing.Point(20, 50);
        cinemaNameTextBox.Name = "cinemaNameTextBox";
        cinemaNameTextBox.Size = new System.Drawing.Size(300, 27);
        cinemaNameTextBox.TabIndex = 1;
        // 
        // cinemaAddressLabel
        //
        cinemaAddressLabel.Location = new System.Drawing.Point(20, 80);
        cinemaAddressLabel.Name = "cinemaAddressLabel";
        cinemaAddressLabel.Text = "Адрес";
        cinemaAddressLabel.Size = new System.Drawing.Size(300, 27);
        cinemaAddressLabel.TabIndex = 2;
        //
        // cinemaAddressTextBox
        //
        cinemaAddressTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        cinemaAddressTextBox.Location = new System.Drawing.Point(20, 110);
        cinemaAddressTextBox.Name = "cinemaAddressTextBox";
        cinemaAddressTextBox.Size = new System.Drawing.Size(300, 27);
        cinemaAddressTextBox.TabIndex = 3;
        //
        // cinemaPhoneLabel
        //
        cinemaPhoneLabel.Location = new System.Drawing.Point(20, 140);
        cinemaPhoneLabel.Name = "cinemaPhoneLabel";
        cinemaPhoneLabel.Text = "Телефон";
        cinemaPhoneLabel.Size = new System.Drawing.Size(300, 27);
        cinemaPhoneLabel.TabIndex = 4;
        //
        // cinemaPhoneTextBox
        //
        cinemaPhoneTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        cinemaPhoneTextBox.Location = new System.Drawing.Point(20, 170);
        cinemaPhoneTextBox.Name = "cinemaPhoneTextBox";
        cinemaPhoneTextBox.Size = new System.Drawing.Size(300, 27);
        cinemaPhoneTextBox.TabIndex = 5;
        //
        // cinemaSeatCapacityLabel
        //
        cinemaSeatCapacityLabel.Location = new System.Drawing.Point(20, 200);
        cinemaSeatCapacityLabel.Name = "cinemaSeatCapacityLabel";
        cinemaSeatCapacityLabel.Text = "Количество посадочных мест";
        cinemaSeatCapacityLabel.Size = new System.Drawing.Size(300, 27);
        cinemaSeatCapacityLabel.TabIndex = 6;
        //
        // cinemaSeatCapacityTextBox
        //
        cinemaSeatCapacityTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        cinemaSeatCapacityTextBox.Location = new System.Drawing.Point(20, 230);
        cinemaSeatCapacityTextBox.Name = "cinemaSeatCapacityTextBox";
        cinemaSeatCapacityTextBox.Size = new System.Drawing.Size(300, 27);
        cinemaSeatCapacityTextBox.TabIndex = 7;
        //
        // cinemaDirectorLabel
        //
        cinemaDirectorLabel.Location = new System.Drawing.Point(20, 260);
        cinemaDirectorLabel.Name = "cinemaDirectorLabel";
        cinemaDirectorLabel.Text = "Директор";
        cinemaDirectorLabel.Size = new System.Drawing.Size(300, 27);
        cinemaDirectorLabel.TabIndex = 8;
        //
        // cinemaDirectorTextBox
        //
        cinemaDirectorTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        cinemaDirectorTextBox.Location = new System.Drawing.Point(20, 290);
        cinemaDirectorTextBox.Name = "cinemaDirectorTextBox";
        cinemaDirectorTextBox.Size = new System.Drawing.Size(300, 27);
        cinemaDirectorTextBox.TabIndex = 9;
        //
        // cinemaOwnerLabel
        //
        cinemaOwnerLabel.Location = new System.Drawing.Point(20, 320);
        cinemaOwnerLabel.Name = "cinemaOwnerLabel";
        cinemaOwnerLabel.Text = "Владелец";
        cinemaOwnerLabel.Size = new System.Drawing.Size(300, 27);
        cinemaOwnerLabel.TabIndex = 10;
        //
        // cinemaOwnerTextBox
        //
        cinemaOwnerTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        cinemaOwnerTextBox.Location = new System.Drawing.Point(20, 350);
        cinemaOwnerTextBox.Name = "cinemaOwnerTextBox";
        cinemaOwnerTextBox.Size = new System.Drawing.Size(300, 27);
        cinemaOwnerTextBox.TabIndex = 11;
        //
        // cinemaBankNameLabel
        //  
        cinemaBankNameLabel.Location = new System.Drawing.Point(20, 380);
        cinemaBankNameLabel.Name = "cinemaBankNameLabel";
        cinemaBankNameLabel.Text = "Банк";
        cinemaBankNameLabel.Size = new System.Drawing.Size(300, 27);
        cinemaBankNameLabel.TabIndex = 12;
        //
        // cinemaBankNameTextBox
        //
        cinemaBankNameTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        cinemaBankNameTextBox.Location = new System.Drawing.Point(20, 410);
        cinemaBankNameTextBox.Name = "cinemaBankNameTextBox";
        cinemaBankNameTextBox.Size = new System.Drawing.Size(300, 27);
        cinemaBankNameTextBox.TabIndex = 13;
        //
        // cinemaBankAccountLabel
        //
        cinemaBankAccountLabel.Location = new System.Drawing.Point(20, 440);
        cinemaBankAccountLabel.Name = "cinemaBankAccountLabel";
        cinemaBankAccountLabel.Text = "Номер счёта";
        cinemaBankAccountLabel.Size = new System.Drawing.Size(300, 27);
        cinemaBankAccountLabel.TabIndex = 14;
        //
        // cinemaBankAccountTextBox
        //
        cinemaBankAccountTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        cinemaBankAccountTextBox.Location = new System.Drawing.Point(20, 470);
        cinemaBankAccountTextBox.Name = "cinemaBankAccountTextBox";
        cinemaBankAccountTextBox.Size = new System.Drawing.Size(300, 27);
        cinemaBankAccountTextBox.TabIndex = 15;
        //
        // cinemaInnLabel
        //
        cinemaInnLabel.Location = new System.Drawing.Point(20, 500);
        cinemaInnLabel.Name = "cinemaInnLabel";
        cinemaInnLabel.Text = "ИНН";
        cinemaInnLabel.Size = new System.Drawing.Size(300, 27);
        cinemaInnLabel.TabIndex = 16;
        //
        // cinemaInnTextBox
        //
        cinemaInnTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        cinemaInnTextBox.Location = new System.Drawing.Point(20, 530);
        cinemaInnTextBox.Name = "cinemaInnTextBox";
        cinemaInnTextBox.Size = new System.Drawing.Size(300, 27);
        cinemaInnTextBox.TabIndex = 17;
        //
        // cinemaTypeComboBox
        //
        cinemaTypeComboBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        cinemaTypeComboBox.Location = new System.Drawing.Point(20, 530);
        cinemaTypeComboBox.Size = new System.Drawing.Size(300, 27);
        cinemaTypeComboBox.TabIndex = 18;
        //
        // additionalLabel
        //
        additionalLabel.Location = new System.Drawing.Point(20, 570);
        additionalLabel.Size = new System.Drawing.Size(300, 27);
        //
        // additionalTextBox
        //
        additionalTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        additionalTextBox.Location = new System.Drawing.Point(20, 600);
        additionalTextBox.Size = new System.Drawing.Size(300, 27);
        //
        // back3Button
        //
        back3Button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
        back3Button.Location = new System.Drawing.Point(20, 640);
        back3Button.Name = "back3Button";
        back3Button.Size = new System.Drawing.Size(100, 30);
        back3Button.TabIndex = 21;
        back3Button.Text = "Назад";
        back3Button.UseVisualStyleBackColor = true;
        back3Button.Click += backButton_Click;
        //
        // addCinemaButton
        //
        addCinemaButton.Anchor = (AnchorStyles.Bottom );
        addCinemaButton.Location = new System.Drawing.Point(500, 640);
        addCinemaButton.Name = "addCinemaButton";
        addCinemaButton.Size = new System.Drawing.Size(100, 30);
        addCinemaButton.TabIndex = 22;
        addCinemaButton.Text = "Сохранить";
        addCinemaButton.UseVisualStyleBackColor = true;
        addCinemaButton.Click += AddCinemaButtonClick;
        
        Controls.Add(addCinemaPanel);
        ResumeLayout(false);
    }
    
    private System.Windows.Forms.Panel addRentPanel;
    private System.Windows.Forms.Label cinemaNameRentLabel;
    private System.Windows.Forms.ComboBox cinemaNameRentComboBox;
    private System.Windows.Forms.Label filmRentLabel;
    private System.Windows.Forms.ComboBox filmRentComboBox;
    private System.Windows.Forms.Label startDateRentLabel;
    private System.Windows.Forms.DateTimePicker startDateRentPicker;
    private System.Windows.Forms.Label endDateRentLabel;
    private System.Windows.Forms.DateTimePicker endDateRentPicker;
    private System.Windows.Forms.Label rentalPriceRentLabel;
    private System.Windows.Forms.TextBox rentalPriceRentTextBox;
    private System.Windows.Forms.Button addRentButton;
    private System.Windows.Forms.Button back4Button;
    
    private void InitializeAddRentPanel()
    {
        addRentPanel = new System.Windows.Forms.Panel();
        cinemaNameRentLabel = new Label();
        cinemaNameRentComboBox = new ComboBox();
        filmRentLabel = new Label();
        filmRentComboBox = new ComboBox();
        startDateRentLabel = new Label();
        startDateRentPicker = new DateTimePicker();
        endDateRentLabel = new Label();
        endDateRentPicker = new DateTimePicker();
        rentalPriceRentLabel = new Label();
        rentalPriceRentTextBox = new TextBox();
        addRentButton = new Button();
        back4Button = new Button();
        
        SuspendLayout();
        //
        // addRentPanel
        //
        addRentPanel.Controls.Add(cinemaNameRentLabel);
        addRentPanel.Controls.Add(cinemaNameRentComboBox);
        addRentPanel.Controls.Add(filmRentLabel);
        addRentPanel.Controls.Add(filmRentComboBox);
        addRentPanel.Controls.Add(startDateRentLabel);
        addRentPanel.Controls.Add(startDateRentPicker);
        addRentPanel.Controls.Add(endDateRentLabel);
        addRentPanel.Controls.Add(endDateRentPicker);
        addRentPanel.Controls.Add(rentalPriceRentLabel);
        addRentPanel.Controls.Add(rentalPriceRentTextBox);
        addRentPanel.Controls.Add(addRentButton);
        addRentPanel.Controls.Add(back4Button);
        addRentPanel.Name = "addRentPanel";
        addRentPanel.Dock = DockStyle.Fill;
        addRentPanel.TabIndex = 1;
        addRentPanel.Visible = false;
        //
        // cinemaNameRentLabel
        //
        cinemaNameRentLabel.Location = new System.Drawing.Point(20, 20);
        cinemaNameRentLabel.Name = "cinemaNameRentLabel";
        cinemaNameRentLabel.Text = "Кинотеатр";
        cinemaNameRentLabel.Size = new System.Drawing.Size(300, 27);
        cinemaNameRentLabel.TabIndex = 0;
        //
        // cinemaNameRentComboBox
        //
        cinemaNameRentComboBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        cinemaNameRentComboBox.Location = new System.Drawing.Point(20, 50);
        cinemaNameRentComboBox.Name = "cinemaNameRentComboBox";
        cinemaNameRentComboBox.Size = new System.Drawing.Size(300, 27);
        cinemaNameRentComboBox.TabIndex = 1;
        //
        // filmRentLabel
        //
        filmRentLabel.Location = new System.Drawing.Point(20, 90);
        filmRentLabel.Name = "filmRentLabel";
        filmRentLabel.Text = "Фильм";
        filmRentLabel.Size = new System.Drawing.Size(300, 27);
        filmRentLabel.TabIndex = 2;
        //
        // filmRentComboBox
        //
        filmRentComboBox.Anchor = ( AnchorStyles.Top |  AnchorStyles.Left | AnchorStyles.Right);
        filmRentComboBox.Location = new System.Drawing.Point(20, 120);
        filmRentComboBox.Name = "filmRentComboBox";
        filmRentComboBox.Size = new System.Drawing.Size(300, 27);
        filmRentComboBox.TabIndex = 3;
        //
        // startDateRentLabel
        //
        startDateRentLabel.Location = new System.Drawing.Point(20, 160);
        startDateRentLabel.Name = "startDateRentLabel";
        startDateRentLabel.Text = "Дата начала демонстрации";
        startDateRentLabel.Size = new System.Drawing.Size(300, 27);
        startDateRentLabel.TabIndex = 4;
        //
        // startDateRentPicker
        //
        startDateRentPicker.Anchor = (AnchorStyles.Top | AnchorStyles.Left );
        startDateRentPicker.Location = new System.Drawing.Point(20, 190);
        startDateRentPicker.Name = "startDateRentPicker";
        startDateRentPicker.Size = new System.Drawing.Size(300, 27);
        startDateRentPicker.TabIndex = 5;
        //
        // endDateRentLabel
        //
        endDateRentLabel.Location = new System.Drawing.Point(20, 230);
        endDateRentLabel.Name = "endDateRentLabel";
        endDateRentLabel.Text = "Дата окончания демонстрации";
        endDateRentLabel.Size = new System.Drawing.Size(300, 27);
        endDateRentLabel.TabIndex = 6;
        //
        // endDateRentPicker
        //
        endDateRentPicker.Anchor = (AnchorStyles.Top | AnchorStyles.Left );
        endDateRentPicker.Location = new System.Drawing.Point(20, 260);
        endDateRentPicker.Name = "endDateRentPicker";
        endDateRentPicker.Size = new System.Drawing.Size(300, 27);
        endDateRentPicker.TabIndex = 7;
        //
        // rentalPriceRentLabel
        //
        rentalPriceRentLabel.Location = new System.Drawing.Point(20, 300);
        rentalPriceRentLabel.Name = "rentalPriceRentLabel";
        rentalPriceRentLabel.Text = "Цена аренды";
        rentalPriceRentLabel.Size = new System.Drawing.Size(300, 27);
        rentalPriceRentLabel.TabIndex = 8;
        //
        // rentalPriceRentTextBox
        //
        rentalPriceRentTextBox.Anchor = ( AnchorStyles.Top |  AnchorStyles.Left | AnchorStyles.Right);
        rentalPriceRentTextBox.Location = new System.Drawing.Point(20, 330);
        rentalPriceRentTextBox.Name = "rentalPriceRentTextBox";
        rentalPriceRentTextBox.Size = new System.Drawing.Size(300, 27);
        rentalPriceRentTextBox.TabIndex = 9;
        //
        //
        // backButton
        //
        back4Button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
        back4Button.Location = new System.Drawing.Point(20, 370);
        back4Button.Name = "back4Button";
        back4Button.Size = new System.Drawing.Size(120, 70);
        back4Button.TabIndex = 10;
        back4Button.Text = "Назад";
        back4Button.UseVisualStyleBackColor = true;
        back4Button.Click += backButton_Click;
        //
        // addCinemaButton
        //
        addRentButton.Anchor = (AnchorStyles.Bottom);
        addRentButton.Location = new System.Drawing.Point(220, 3700);
        addRentButton.Name = "addRentButton";
        addRentButton.Size = new System.Drawing.Size(120, 70);
        addRentButton.TabIndex = 11;
        addRentButton.Text = "Добавить";
        addRentButton.UseVisualStyleBackColor = true;
        addRentButton.Click += AddRentButtonClick;
        
        Controls.Add(addRentPanel);
        ResumeLayout(false);
    }

    #endregion
}