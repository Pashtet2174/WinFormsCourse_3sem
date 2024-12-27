using System.ComponentModel;

namespace WinFormsCourse_3sem;

partial class ShowRentsForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowRentsForm));
        rentsGridView1 = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)rentsGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        rentsGridView1.Name = "rentsGridView1";
        rentsGridView1.Text = "dataGridView1";
        rentsGridView1.Dock = DockStyle.Fill;
        rentsGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        rentsGridView1.AllowUserToAddRows = false;
        rentsGridView1.ReadOnly = true;
        rentsGridView1.DefaultCellStyle.SelectionBackColor = rentsGridView1.DefaultCellStyle.BackColor;
        rentsGridView1.DefaultCellStyle.SelectionForeColor = rentsGridView1.DefaultCellStyle.ForeColor;
        rentsGridView1.Columns.Add("Cinema", "Кинотеатр");
        rentsGridView1.Columns.Add("Film", "Фильм");
        rentsGridView1.Columns.Add("StartDate", "Дата начала");
        rentsGridView1.Columns.Add("EndDate", "Дата окончания");
        rentsGridView1.Columns.Add("RentalPrice", "Стоимость аренды");
        // 
        // ShowRentsForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(rentsGridView1);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        MinimumSize = new System.Drawing.Size(800, 800);
        Text = "Список арендованных фильмов";
        ((System.ComponentModel.ISupportInitialize)rentsGridView1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView rentsGridView1;

    #endregion
}