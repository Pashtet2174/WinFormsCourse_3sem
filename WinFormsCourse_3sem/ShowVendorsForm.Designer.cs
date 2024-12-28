using System.ComponentModel;

namespace WinFormsCourse_3sem;

partial class ShowVendorsForm
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
        vensorsGridView = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)vensorsGridView).BeginInit();
        SuspendLayout();
        // 
        // vensorsGridView
        // 
        vensorsGridView.Name = "vensorsGridView";
        vensorsGridView.Text = "vensorsGridView";
        vensorsGridView.Dock = DockStyle.Fill;
        vensorsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        vensorsGridView.AllowUserToAddRows = false;
        vensorsGridView.ReadOnly = true;
        vensorsGridView.DefaultCellStyle.SelectionBackColor = vensorsGridView.DefaultCellStyle.BackColor;
        vensorsGridView.DefaultCellStyle.SelectionForeColor = vensorsGridView.DefaultCellStyle.ForeColor;
        vensorsGridView.Columns.Add("Name", "Поставщик кинолент");
        vensorsGridView.Columns.Add("LegalAddress", "Юридический адрес");
        vensorsGridView.Columns.Add("BankName", "Банк");
        vensorsGridView.Columns.Add("BankAccountNumber", "Номер счёта");
        vensorsGridView.Columns.Add("Inn", "ИНН");
        vensorsGridView.Columns.Add("Films", "Фильмы поставщика");
        // 
        // ShowVendorsForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(vensorsGridView);
        Text = "Список поставщиков";
        MinimumSize = new System.Drawing.Size(1000, 1000);
        ((System.ComponentModel.ISupportInitialize)vensorsGridView).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView vensorsGridView;

    #endregion
}