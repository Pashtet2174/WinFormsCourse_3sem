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
        panel1 = new System.Windows.Forms.Panel();
        textBox1 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // addVendorButton
        // 
        addVendorButton.Location = new System.Drawing.Point(128, 77);
        addVendorButton.Name = "addVendorButton";
        addVendorButton.Size = new System.Drawing.Size(119, 73);
        addVendorButton.TabIndex = 0;
        addVendorButton.Text = "Добавить поставщика";
        addVendorButton.UseVisualStyleBackColor = true;
        addVendorButton.Click += addVendorButton_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(textBox1);
        panel1.Controls.Add(button1);
        panel1.Dock = System.Windows.Forms.DockStyle.Top;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(924, 426);
        panel1.TabIndex = 1;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(72, 215);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(131, 27);
        textBox1.TabIndex = 1;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(45, 56);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(96, 93);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ControlLight;
        ClientSize = new System.Drawing.Size(924, 810);
        Controls.Add(panel1);
        Controls.Add(addVendorButton);
        Text = "Система учёта аренды фильмов";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Button addVendorButton;

    private System.Windows.Forms.Panel addVendorPanel; // Панель для добавления поставщика

    private void InitializeAddVendorPanel()
    {
        
        // Создаём панель
        addVendorPanel = new Panel
        {
            Dock = DockStyle.Fill, // Заполняет всю форму
            Visible = false, // Скрыта по умолчанию
            BackColor = SystemColors.ControlLight
        };

        // Добавляем элементы на панель
        Label nameLabel = new Label { Text = "Название:", Location = new Point(10, 10) };
        TextBox nameTextBox = new TextBox { Location = new Point(120, 10), Width = 200 };

        Label addressLabel = new Label { Text = "Юридический адрес:", Location = new Point(10, 50) };
        TextBox addressTextBox = new TextBox { Location = new Point(120, 50), Width = 200 };

        Label bankNameLabel = new Label { Text = "Банк:", Location = new Point(10, 90) };
        TextBox bankNameTextBox = new TextBox { Location = new Point(120, 90), Width = 200 };

        Label accountLabel = new Label { Text = "Счёт:", Location = new Point(10, 130) };
        TextBox accountTextBox = new TextBox { Location = new Point(120, 130), Width = 200 };

        Label innLabel = new Label { Text = "ИНН:", Location = new Point(10, 170) };
        TextBox innTextBox = new TextBox { Location = new Point(120, 170), Width = 200 };

        Button addButton = new Button { Text = "Добавить", Location = new Point(10, 210) };
        Button backButton = new Button { Text = "Назад", Location = new Point(120, 210) };

        // Обработчики событий
        addButton.Click += (sender, e) =>
        {
            // Здесь добавляем поставщика
            MessageBox.Show("Поставщик добавлен!");
            // Очистка полей после добавления
            nameTextBox.Text = "";
            addressTextBox.Text = "";
            bankNameTextBox.Text = "";
            accountTextBox.Text = "";
            innTextBox.Text = "";
        };

        backButton.Click += backButton_Click;
        
        // Добавляем элементы на панель
        addVendorPanel.Controls.Add(nameLabel);
        addVendorPanel.Controls.Add(nameTextBox);
        addVendorPanel.Controls.Add(addressLabel);
        addVendorPanel.Controls.Add(addressTextBox);
        addVendorPanel.Controls.Add(bankNameLabel);
        addVendorPanel.Controls.Add(bankNameTextBox);
        addVendorPanel.Controls.Add(accountLabel);
        addVendorPanel.Controls.Add(accountTextBox);
        addVendorPanel.Controls.Add(innLabel);
        addVendorPanel.Controls.Add(innTextBox);
        addVendorPanel.Controls.Add(addButton);
        addVendorPanel.Controls.Add(backButton);

        // Добавляем панель на форму
        Controls.Add(addVendorPanel);
    }

    
    #endregion
}