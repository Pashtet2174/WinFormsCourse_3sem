using System.ComponentModel;

namespace WinFormsCourse_3sem;

partial class ShowCinemasForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        cinemasGridView = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)cinemasGridView).BeginInit();
        SuspendLayout();
        // 
        // cinemasGridView
        // 
        cinemasGridView.Name = "cinemasGridView";
        cinemasGridView.Text = "dataGridView1";
        cinemasGridView.Dock = DockStyle.Fill;
        cinemasGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        cinemasGridView.AllowUserToAddRows = false;
        cinemasGridView.ReadOnly = true;
        cinemasGridView.DefaultCellStyle.SelectionBackColor = cinemasGridView.DefaultCellStyle.BackColor;
        cinemasGridView.DefaultCellStyle.SelectionForeColor = cinemasGridView.DefaultCellStyle.ForeColor;
        cinemasGridView.Columns.Add("Name", "Название кинотеатра");
        cinemasGridView.Columns.Add("Address", "Адрес");
        cinemasGridView.Columns.Add("Phone", "Телефона");
        cinemasGridView.Columns.Add("SeatCapacity", "Количество посадочных мест");
        cinemasGridView.Columns.Add("Director", "Директор");
        cinemasGridView.Columns.Add("Owner", "Владелец");
        cinemasGridView.Columns.Add("BankName", "Банк");
        cinemasGridView.Columns.Add("BankAccountNumber", "Номер счёта");
        cinemasGridView.Columns.Add("Inn", "ИНН");
        
        // 
        // ShowCinemasForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1700, 800);
        Controls.Add(cinemasGridView);
        MinimumSize = new System.Drawing.Size(1700, 800);
        Text = "Список кинотеатров";
        ((System.ComponentModel.ISupportInitialize)cinemasGridView).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView cinemasGridView;

    #endregion
}