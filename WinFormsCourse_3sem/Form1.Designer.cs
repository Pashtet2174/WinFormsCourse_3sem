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
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        button5 = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        button6 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        button1.ForeColor = System.Drawing.SystemColors.Desktop;
        button1.Location = new System.Drawing.Point(37, 80);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(110, 60);
        button1.TabIndex = 0;
        button1.Text = "Добавить кинотеатр";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        button2.Location = new System.Drawing.Point(236, 80);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(110, 60);
        button2.TabIndex = 1;
        button2.Text = "Добавить поставщика";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        button3.Location = new System.Drawing.Point(405, 80);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(110, 60);
        button3.TabIndex = 2;
        button3.Text = "Добавить фильм";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(591, 81);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(110, 60);
        button4.TabIndex = 3;
        button4.Text = "Создать аренду";
        button4.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.Location = new System.Drawing.Point(683, 465);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(135, 84);
        button5.TabIndex = 4;
        button5.Text = "Сохранить данные и выйти ";
        button5.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(1, 1);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(846, 27);
        textBox1.TabIndex = 5;
        textBox1.Text = "Главное меню";
        textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // button6
        // 
        button6.Location = new System.Drawing.Point(623, 222);
        button6.Name = "button6";
        button6.Size = new System.Drawing.Size(116, 82);
        button6.TabIndex = 6;
        button6.Text = "Показать список аренды\r\n\r\n\r\n\r\n\r\n";
        button6.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ControlLight;
        ClientSize = new System.Drawing.Size(849, 570);
        Controls.Add(button6);
        Controls.Add(textBox1);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Text = "Система учёта аренды фильмов";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button6;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    #endregion
}