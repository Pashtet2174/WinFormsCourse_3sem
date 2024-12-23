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
        addVendorButton = new System.Windows.Forms.Button();
        addFilmButton = new System.Windows.Forms.Button();
        addCinemaButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // addVendorButton
        // 
        addVendorButton.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
        addVendorButton.Location = new System.Drawing.Point(51, 77);
        addVendorButton.Name = "addVendorButton";
        addVendorButton.Size = new System.Drawing.Size(135, 73);
        addVendorButton.TabIndex = 0;
        addVendorButton.Text = "Добавить поставщика";
        addVendorButton.UseVisualStyleBackColor = true;
        addVendorButton.Click += addVendorButton_Click;
        // 
        // addFilmButton
        // 
        addFilmButton.Anchor = (AnchorStyles.Top);
        addFilmButton.Location = new System.Drawing.Point(250, 77);
        addFilmButton.Name = "addFilmButton";
        addFilmButton.Size = new System.Drawing.Size(135, 73);
        addFilmButton.TabIndex = 1;
        addFilmButton.Text = "Добавить фильм";
        addFilmButton.UseVisualStyleBackColor = true;
        addFilmButton.Click += addFilmButton_Click;
        // 
        // addCinemaButton
        // 
        addCinemaButton.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
        addCinemaButton.Location = new System.Drawing.Point(450, 77);
        addCinemaButton.Name = "addCinemaButton";
        addCinemaButton.Size = new System.Drawing.Size(135, 73);
        addCinemaButton.TabIndex = 2;
        addCinemaButton.Text = "Добавить кинотеатр";
        addCinemaButton.UseVisualStyleBackColor = true;
        addCinemaButton.Click += addCinemaButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ControlLight;
        ClientSize = new System.Drawing.Size(823, 753);
        Controls.Add(addCinemaButton);
        Controls.Add(addFilmButton);
        Controls.Add(addVendorButton);
        MinimumSize = new System.Drawing.Size(800, 800);
        Text = "Система учёта аренды фильмов";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button addCinemaButton;
    private System.Windows.Forms.Button addFilmButton;
    private System.Windows.Forms.Button addVendorButton;
    
    private System.Windows.Forms.Panel addVendorPanel;
    private System.Windows.Forms.TextBox vendorNameTextBox;
    private System.Windows.Forms.TextBox vendorLegalAddressTextBox;
    private System.Windows.Forms.Button backButton;
    private System.Windows.Forms.Button saveVendorButton;
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
        saveVendorButton = new System.Windows.Forms.Button();
        saveAndBackButton = new System.Windows.Forms.Button();
        SuspendLayout();
        
        addVendorPanel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
        vendorNameTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        vendorLegalAddressTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        vendorBankTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        vendorBankAccountTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        vendorINNTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        backButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
        saveVendorButton.Anchor = (AnchorStyles.Bottom);
        saveAndBackButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
        
        // addVendorPanel
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
        addVendorPanel.Controls.Add(saveVendorButton); 
        addVendorPanel.Controls.Add(saveAndBackButton); 
        addVendorPanel.Name = "addVendorPanel";
        addVendorPanel.Dock = DockStyle.Fill;
        addVendorPanel.TabIndex = 1; 
        addVendorPanel.Visible = false;
        
        // vendorNameLabel
        vendorNameLabel.Location = new System.Drawing.Point(20, 20); 
        vendorNameLabel.Name = "vendorNameLabel";
        vendorNameLabel.Text = "Поставщик";
        vendorNameLabel.Size = new System.Drawing.Size(300, 27); 
        vendorNameLabel.TabIndex = 0;
        
        // vendorNameTextBox
        vendorNameTextBox.Location = new System.Drawing.Point(20, 50); 
        vendorNameTextBox.Name = "vendorNameTextBox"; 
        vendorNameTextBox.Size = new System.Drawing.Size(300, 27); 
        vendorNameTextBox.TabIndex = 1;
        
        // vendorLegalAddressLabel
        vendorLegalAddressLabel.Location = new System.Drawing.Point(20, 80); 
        vendorLegalAddressLabel.Name = "vendorLegalAddressLabel";
        vendorLegalAddressLabel.Text = "Юридический адресс";
        vendorLegalAddressLabel.Size = new System.Drawing.Size(300, 27); 
        vendorLegalAddressLabel.TabIndex = 2;

        // vendorLegalAddressTextBox
        vendorLegalAddressTextBox.Location = new System.Drawing.Point(20, 110); 
        vendorLegalAddressTextBox.Name = "vendorLegalAddressTextBox"; 
        vendorLegalAddressTextBox.Size = new System.Drawing.Size(300, 27); 
        vendorLegalAddressTextBox.TabIndex = 3;
        
        // vendorBankLabel
        vendorBankLabel.Location = new System.Drawing.Point(20, 140); 
        vendorBankLabel.Name = "vendorBankLabel";
        vendorBankLabel.Text = "Банк";
        vendorBankLabel.Size = new System.Drawing.Size(300, 27); 
        vendorBankLabel.TabIndex = 4;

        // vendorBankTextBox
        vendorBankTextBox.Location = new System.Drawing.Point(20, 170); 
        vendorBankTextBox.Name = "vendorBankTextBox"; 
        vendorBankTextBox.Size = new System.Drawing.Size(300, 27); 
        vendorBankTextBox.TabIndex = 5;
        
        // vendorBankAccountLabel
        vendorBankAccountLabel.Location = new System.Drawing.Point(20, 200); 
        vendorBankAccountLabel.Name = "vendorBankAccountLabel";
        vendorBankAccountLabel.Text = "Номер счёта";
        vendorBankAccountLabel.Size = new System.Drawing.Size(300, 27); 
        vendorBankAccountLabel.TabIndex = 6;

        // vendorBankAccountTextBox
        vendorBankAccountTextBox.Location = new System.Drawing.Point(20, 230); 
        vendorBankAccountTextBox.Name = "vendorBankAccountTextBox"; 
        vendorBankAccountTextBox.Size = new System.Drawing.Size(300, 27); 
        vendorBankAccountTextBox.TabIndex = 7;
        
        // vendorINNLabel
        vendorINNLabel.Location = new System.Drawing.Point(20, 260); 
        vendorINNLabel.Name = "vendorINNLabel";
        vendorINNLabel.Text = "Инн";
        vendorINNLabel.Size = new System.Drawing.Size(300, 27); 
        vendorINNLabel.TabIndex = 8;

        // vendorINNTextBox
        vendorINNTextBox.Location = new System.Drawing.Point(20, 290); 
        vendorINNTextBox.Name = "vendorINNTextBox"; 
        vendorINNTextBox.Size = new System.Drawing.Size(300, 27); 
        vendorINNTextBox.TabIndex = 9;

        // backButton
        backButton.Location = new System.Drawing.Point(20, 350);
        backButton.Name = "backButton"; 
        backButton.Size = new System.Drawing.Size(100, 30);
        backButton.TabIndex = 2; 
        backButton.Text = "Назад"; 
        backButton.UseVisualStyleBackColor = true; 
        backButton.Click += backButton_Click;

        // saveVendorButton
        saveVendorButton.Location = new System.Drawing.Point(220, 350); 
        saveVendorButton.Name = "saveVendorButton"; 
        saveVendorButton.Size = new System.Drawing.Size(100, 30);
        saveVendorButton.TabIndex = 3; 
        saveVendorButton.Text = "Сохранить"; 
        saveVendorButton.UseVisualStyleBackColor = true; 
        saveVendorButton.Click += saveVendorButton_Click;
        
        //saveAndBackButton
        saveAndBackButton.Location = new System.Drawing.Point(350, 350); 
        saveAndBackButton.Name = "saveVendorButton"; 
        saveAndBackButton.Size = new System.Drawing.Size(100, 30);
        saveAndBackButton.TabIndex = 4; 
        saveAndBackButton.Text = "Сохранить данные и выйти"; 
        saveAndBackButton.UseVisualStyleBackColor = true; 
        saveAndBackButton.Click += saveAndBackButton_Click;
        
        // Add panel to form
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
    private System.Windows.Forms.ComboBox supplierComboBox;
    private System.Windows.Forms.Label filmNameLabel;
    private System.Windows.Forms.Label filmCategoryLabel;
    private System.Windows.Forms.Label filmScriptwriterLabel;
    private System.Windows.Forms.Label filmProductionDirectorLabel;
    private System.Windows.Forms.Label filmProductionCompanyLabel;
    private System.Windows.Forms.Label filmReleaseYearLabel;
    private System.Windows.Forms.Label filmCostLabel;
    private System.Windows.Forms.Label supplierLabel;
    private System.Windows.Forms.Button saveFilmButton;
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
        supplierLabel = new Label();
        supplierComboBox = new ComboBox();
        back2Button = new System.Windows.Forms.Button();
        saveFilmButton = new System.Windows.Forms.Button();
        //saveAndBackButton = new System.Windows.Forms.Button();

        SuspendLayout();

        // addFilmPanel
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
        addFilmPanel.Controls.Add(supplierLabel);
        addFilmPanel.Controls.Add(supplierComboBox);
        addFilmPanel.Controls.Add(back2Button);
        addFilmPanel.Controls.Add(saveFilmButton);
        //addFilmPanel.Controls.Add(saveAndBackButton);

        addFilmPanel.Name = "addFilmPanel";
        addFilmPanel.Dock = DockStyle.Fill;
        addFilmPanel.TabIndex = 1;
        addFilmPanel.Visible = false;

        // filmNameLabel
        filmNameLabel.Location = new System.Drawing.Point(20, 20);
        filmNameLabel.Name = "filmNameLabel";
        filmNameLabel.Text = "Название фильма";
        filmNameLabel.Size = new System.Drawing.Size(300, 27);
        filmNameLabel.TabIndex = 0;

        // filmNameTextBox
        filmNameTextBox.Location = new System.Drawing.Point(20, 50);
        filmNameTextBox.Name = "filmNameTextBox";
        filmNameTextBox.Size = new System.Drawing.Size(300, 27);
        filmNameTextBox.TabIndex = 1;

        // filmCategoryLabel
        filmCategoryLabel.Location = new System.Drawing.Point(20, 80);
        filmCategoryLabel.Name = "filmCategoryLabel";
        filmCategoryLabel.Text = "Категория";
        filmCategoryLabel.Size = new System.Drawing.Size(300, 27);
        filmCategoryLabel.TabIndex = 2;

        // filmCategoryTextBox
        filmCategoryTextBox.Location = new System.Drawing.Point(20, 110);
        filmCategoryTextBox.Name = "filmCategoryTextBox";
        filmCategoryTextBox.Size = new System.Drawing.Size(300, 27);
        filmCategoryTextBox.TabIndex = 3;

        // filmScriptwriterLabel
        filmScriptwriterLabel.Location = new System.Drawing.Point(20, 140);
        filmScriptwriterLabel.Name = "filmScriptwriterLabel";
        filmScriptwriterLabel.Text = "Сценарист";
        filmScriptwriterLabel.Size = new System.Drawing.Size(300, 27);
        filmScriptwriterLabel.TabIndex = 4;

        // filmScriptwriterTextBox
        filmScriptwriterTextBox.Location = new System.Drawing.Point(20, 170);
        filmScriptwriterTextBox.Name = "filmScriptwriterTextBox";
        filmScriptwriterTextBox.Size = new System.Drawing.Size(300, 27);
        filmScriptwriterTextBox.TabIndex = 5;

        // filmProductionDirectorLabel
        filmProductionDirectorLabel.Location = new System.Drawing.Point(20, 200);
        filmProductionDirectorLabel.Name = "filmProductionDirectorLabel";
        filmProductionDirectorLabel.Text = "Режиссёр";
        filmProductionDirectorLabel.Size = new System.Drawing.Size(300, 27);
        filmProductionDirectorLabel.TabIndex = 6;

        // filmProductionDirectorTextBox
        filmProductionDirectorTextBox.Location = new System.Drawing.Point(20, 230);
        filmProductionDirectorTextBox.Name = "filmProductionDirectorTextBox";
        filmProductionDirectorTextBox.Size = new System.Drawing.Size(300, 27);
        filmProductionDirectorTextBox.TabIndex = 7;

        // filmProductionCompanyLabel
        filmProductionCompanyLabel.Location = new System.Drawing.Point(20, 260);
        filmProductionCompanyLabel.Name = "filmProductionCompanyLabel";
        filmProductionCompanyLabel.Text = "Продюсерская компания";
        filmProductionCompanyLabel.Size = new System.Drawing.Size(300, 27);
        filmProductionCompanyLabel.TabIndex = 8;

        // filmProductionCompanyTextBox
        filmProductionCompanyTextBox.Location = new System.Drawing.Point(20, 290);
        filmProductionCompanyTextBox.Name = "filmProductionCompanyTextBox";
        filmProductionCompanyTextBox.Size = new System.Drawing.Size(300, 27);
        filmProductionCompanyTextBox.TabIndex = 9;

        // filmReleaseYearLabel
        filmReleaseYearLabel.Location = new System.Drawing.Point(20, 320);
        filmReleaseYearLabel.Name = "filmReleaseYearLabel";
        filmReleaseYearLabel.Text = "Год выпуска";
        filmReleaseYearLabel.Size = new System.Drawing.Size(300, 27);
        filmReleaseYearLabel.TabIndex = 10;

        // filmReleaseYearTextBox
        filmReleaseYearTextBox.Location = new System.Drawing.Point(20, 350);
        filmReleaseYearTextBox.Name = "filmReleaseYearTextBox";
        filmReleaseYearTextBox.Size = new System.Drawing.Size(300, 27);
        filmReleaseYearTextBox.TabIndex = 11;

        // filmCostLabel
        filmCostLabel.Location = new System.Drawing.Point(20, 380);
        filmCostLabel.Name = "filmCostLabel";
        filmCostLabel.Text = "Стоимость";
        filmCostLabel.Size = new System.Drawing.Size(300, 27);
        filmCostLabel.TabIndex = 12;

        // filmCostTextBox
        filmCostTextBox.Location = new System.Drawing.Point(20, 410);
        filmCostTextBox.Name = "filmCostTextBox";
        filmCostTextBox.Size = new System.Drawing.Size(300, 27);
        filmCostTextBox.TabIndex = 13;

        // supplierLabel
        supplierLabel.Location = new System.Drawing.Point(20, 440);
        supplierLabel.Name = "supplierLabel";
        supplierLabel.Text = "Поставщик";
        supplierLabel.Size = new System.Drawing.Size(300, 27);
        supplierLabel.TabIndex = 14;

        // supplierComboBox
        supplierComboBox.Location = new System.Drawing.Point(20, 470);
        supplierComboBox.Name = "supplierComboBox";
        supplierComboBox.Size = new System.Drawing.Size(300, 27);
        supplierComboBox.TabIndex = 15;
        
        // back2Button
        back2Button.Location = new System.Drawing.Point(20, 510);
        back2Button.Name = "backButton";
        back2Button.Size = new System.Drawing.Size(100, 30);
        back2Button.TabIndex = 16;
        back2Button.Text = "Назад";
        back2Button.UseVisualStyleBackColor = true;
        back2Button.Click += backButton_Click;

        // saveFilmButton
        saveFilmButton.Location = new System.Drawing.Point(220, 510);
        saveFilmButton.Name = "saveFilmButton";
        saveFilmButton.Size = new System.Drawing.Size(100, 30);
        saveFilmButton.TabIndex = 17;
        saveFilmButton.Text = "Сохранить";
        saveFilmButton.UseVisualStyleBackColor = true;
        saveFilmButton.Click += saveFilmButton_Click;

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
        private System.Windows.Forms.Button saveCinemaButton;
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
            saveCinemaButton = new System.Windows.Forms.Button();
            
            cinemaTypeComboBox = new ComboBox();
            cinemaTypeComboBox.Items.Add("Традиционный");
            cinemaTypeComboBox.Items.Add("Под открытым небом");
            cinemaTypeComboBox.Items.Add("4D");
            cinemaTypeComboBox.SelectedIndexChanged += CinemaTypeComboBox_SelectedIndexChanged;

            // additional field (Label and TextBox)
            additionalLabel = new Label();
            additionalTextBox = new TextBox();
            
            
            
            SuspendLayout();

            // addCinemaPanel
            
            addCinemaPanel.Controls.Add(cinemaTypeComboBox); // add cinemaTypeComboBox
            addCinemaPanel.Controls.Add(additionalLabel); // add additionalLabel
            addCinemaPanel.Controls.Add(additionalTextBox); // add additionalTextBox
            
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
            addCinemaPanel.Controls.Add(saveCinemaButton);
            addCinemaPanel.Name = "addCinemaPanel";
            addCinemaPanel.Dock = DockStyle.Fill;
            addCinemaPanel.TabIndex = 1;
            addCinemaPanel.Visible = false;

            // cinemaNameLabel
            cinemaNameLabel.Location = new System.Drawing.Point(20, 20);
            cinemaNameLabel.Name = "cinemaNameLabel";
            cinemaNameLabel.Text = "Название кинотеатра";
            cinemaNameLabel.Size = new System.Drawing.Size(300, 27);
            cinemaNameLabel.TabIndex = 0;

            // cinemaNameTextBox
            cinemaNameTextBox.Location = new System.Drawing.Point(20, 50);
            cinemaNameTextBox.Name = "cinemaNameTextBox";
            cinemaNameTextBox.Size = new System.Drawing.Size(300, 27);
            cinemaNameTextBox.TabIndex = 1;

            // cinemaAddressLabel
            cinemaAddressLabel.Location = new System.Drawing.Point(20, 80);
            cinemaAddressLabel.Name = "cinemaAddressLabel";
            cinemaAddressLabel.Text = "Адрес";
            cinemaAddressLabel.Size = new System.Drawing.Size(300, 27);
            cinemaAddressLabel.TabIndex = 2;

            // cinemaAddressTextBox
            cinemaAddressTextBox.Location = new System.Drawing.Point(20, 110);
            cinemaAddressTextBox.Name = "cinemaAddressTextBox";
            cinemaAddressTextBox.Size = new System.Drawing.Size(300, 27);
            cinemaAddressTextBox.TabIndex = 3;

            // cinemaPhoneLabel
            cinemaPhoneLabel.Location = new System.Drawing.Point(20, 140);
            cinemaPhoneLabel.Name = "cinemaPhoneLabel";
            cinemaPhoneLabel.Text = "Телефон";
            cinemaPhoneLabel.Size = new System.Drawing.Size(300, 27);
            cinemaPhoneLabel.TabIndex = 4;

            // cinemaPhoneTextBox
            cinemaPhoneTextBox.Location = new System.Drawing.Point(20, 170);
            cinemaPhoneTextBox.Name = "cinemaPhoneTextBox";
            cinemaPhoneTextBox.Size = new System.Drawing.Size(300, 27);
            cinemaPhoneTextBox.TabIndex = 5;

            // cinemaSeatCapacityLabel
            cinemaSeatCapacityLabel.Location = new System.Drawing.Point(20, 200);
            cinemaSeatCapacityLabel.Name = "cinemaSeatCapacityLabel";
            cinemaSeatCapacityLabel.Text = "Количество мест";
            cinemaSeatCapacityLabel.Size = new System.Drawing.Size(300, 27);
            cinemaSeatCapacityLabel.TabIndex = 6;

            // cinemaSeatCapacityTextBox
            cinemaSeatCapacityTextBox.Location = new System.Drawing.Point(20, 230);
            cinemaSeatCapacityTextBox.Name = "cinemaSeatCapacityTextBox";
            cinemaSeatCapacityTextBox.Size = new System.Drawing.Size(300, 27);
            cinemaSeatCapacityTextBox.TabIndex = 7;

            // cinemaDirectorLabel
            cinemaDirectorLabel.Location = new System.Drawing.Point(20, 260);
            cinemaDirectorLabel.Name = "cinemaDirectorLabel";
            cinemaDirectorLabel.Text = "Директор";
            cinemaDirectorLabel.Size = new System.Drawing.Size(300, 27);
            cinemaDirectorLabel.TabIndex = 8;

            // cinemaDirectorTextBox
            cinemaDirectorTextBox.Location = new System.Drawing.Point(20, 290);
            cinemaDirectorTextBox.Name = "cinemaDirectorTextBox";
            cinemaDirectorTextBox.Size = new System.Drawing.Size(300, 27);
            cinemaDirectorTextBox.TabIndex = 9;

            // cinemaOwnerLabel
            cinemaOwnerLabel.Location = new System.Drawing.Point(20, 320);
            cinemaOwnerLabel.Name = "cinemaOwnerLabel";
            cinemaOwnerLabel.Text = "Владелец";
            cinemaOwnerLabel.Size = new System.Drawing.Size(300, 27);
            cinemaOwnerLabel.TabIndex = 10;

            // cinemaOwnerTextBox
            cinemaOwnerTextBox.Location = new System.Drawing.Point(20, 350);
            cinemaOwnerTextBox.Name = "cinemaOwnerTextBox";
            cinemaOwnerTextBox.Size = new System.Drawing.Size(300, 27);
            cinemaOwnerTextBox.TabIndex = 11;

            // cinemaBankNameLabel
            cinemaBankNameLabel.Location = new System.Drawing.Point(20, 380);
            cinemaBankNameLabel.Name = "cinemaBankNameLabel";
            cinemaBankNameLabel.Text = "Банк";
            cinemaBankNameLabel.Size = new System.Drawing.Size(300, 27);
            cinemaBankNameLabel.TabIndex = 12;

            // cinemaBankNameTextBox
            cinemaBankNameTextBox.Location = new System.Drawing.Point(20, 410);
            cinemaBankNameTextBox.Name = "cinemaBankNameTextBox";
            cinemaBankNameTextBox.Size = new System.Drawing.Size(300, 27);
            cinemaBankNameTextBox.TabIndex = 13;

            // cinemaBankAccountLabel
            cinemaBankAccountLabel.Location = new System.Drawing.Point(20, 440);
            cinemaBankAccountLabel.Name = "cinemaBankAccountLabel";
            cinemaBankAccountLabel.Text = "Номер счёта";
            cinemaBankAccountLabel.Size = new System.Drawing.Size(300, 27);
            cinemaBankAccountLabel.TabIndex = 14;

            // cinemaBankAccountTextBox
            cinemaBankAccountTextBox.Location = new System.Drawing.Point(20, 470);
            cinemaBankAccountTextBox.Name = "cinemaBankAccountTextBox";
            cinemaBankAccountTextBox.Size = new System.Drawing.Size(300, 27);
            cinemaBankAccountTextBox.TabIndex = 15;

            // cinemaInnLabel
            cinemaInnLabel.Location = new System.Drawing.Point(20, 500);
            cinemaInnLabel.Name = "cinemaInnLabel";
            cinemaInnLabel.Text = "ИНН";
            cinemaInnLabel.Size = new System.Drawing.Size(300, 27);
            cinemaInnLabel.TabIndex = 16;

            // cinemaInnTextBox
            cinemaInnTextBox.Location = new System.Drawing.Point(20, 530);
            cinemaInnTextBox.Name = "cinemaInnTextBox";
            cinemaInnTextBox.Size = new System.Drawing.Size(300, 27);
            cinemaInnTextBox.TabIndex = 17;

            // position the ComboBox for selecting cinema type
            cinemaTypeComboBox.Location = new System.Drawing.Point(20, 530);
            cinemaTypeComboBox.Name = "cinemaTypeComboBox";
            cinemaTypeComboBox.Size = new System.Drawing.Size(300, 27);
            cinemaTypeComboBox.TabIndex = 18;

            // position the additional Label and TextBox
            additionalLabel.Location = new System.Drawing.Point(20, 570);
            additionalLabel.Size = new System.Drawing.Size(300, 27);
            additionalTextBox.Location = new System.Drawing.Point(20, 600);
            additionalTextBox.Size = new System.Drawing.Size(300, 27);

            // backButton
            back3Button.Location = new System.Drawing.Point(20, 640);
            back3Button.Name = "backButton";
            back3Button.Size = new System.Drawing.Size(100, 30);
            back3Button.TabIndex = 19;
            back3Button.Text = "Назад";
            back3Button.UseVisualStyleBackColor = true;
            back3Button.Click += backButton_Click;

            // saveCinemaButton
            saveCinemaButton.Location = new System.Drawing.Point(220, 640);
            saveCinemaButton.Name = "saveCinemaButton";
            saveCinemaButton.Size = new System.Drawing.Size(100, 30);
            saveCinemaButton.TabIndex = 20;
            saveCinemaButton.Text = "Сохранить";
            saveCinemaButton.UseVisualStyleBackColor = true;
            saveCinemaButton.Click += saveCinemaButton_Click;

            
            Controls.Add(addCinemaPanel);
            ResumeLayout(false);
        }

    #endregion
}