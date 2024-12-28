using System.ComponentModel;

namespace WinFormsCourse_3sem;

partial class ShowFilmsForm
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        filmsGridView = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)filmsGridView).BeginInit();
        SuspendLayout();
        // 
        // filmsGridView
        // 
        filmsGridView.Name = "filmsGridView";
        filmsGridView.Text = " filmsGridView";
        filmsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
        filmsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        filmsGridView.AllowUserToAddRows = false;
        filmsGridView.ReadOnly = true;
        filmsGridView.DefaultCellStyle.SelectionBackColor = filmsGridView.DefaultCellStyle.BackColor;
        filmsGridView.DefaultCellStyle.SelectionForeColor = filmsGridView.DefaultCellStyle.ForeColor;
        filmsGridView.Columns.Add("Name", "Название кинофильма");
        filmsGridView.Columns.Add("Category", "Категория");
        filmsGridView.Columns.Add("Scriptwriter", "Автор сценария");
        filmsGridView.Columns.Add("ProductionDirector", "Режиссёр-постановщик");
        filmsGridView.Columns.Add("ProductionCompany", "Компания производитель");    
        filmsGridView.Columns.Add("ReleaseYear", "Год выхода на экран");
        filmsGridView.Columns.Add("Cost", "Стоимость приобретения");
        // 
        // ShowFilmsForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(882, 853);
        Controls.Add(filmsGridView);
        MinimumSize = new System.Drawing.Size(900, 900);
        Text = "Список фильмов";
        ((System.ComponentModel.ISupportInitialize)filmsGridView).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView filmsGridView;

    #endregion
}