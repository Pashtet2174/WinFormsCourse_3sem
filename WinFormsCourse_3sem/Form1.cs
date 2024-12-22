namespace WinFormsCourse_3sem;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        InitializeAddVendorPanel();

    }


    private void addVendorButton_Click(object sender, EventArgs e)
    {
        foreach (Control control in Controls)
        {
            control.Visible = false;
        }

        // Показываем панель для добавления поставщика
        addVendorPanel.Visible = true;
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        addVendorPanel.Visible = false; // Скрываем панель добавления поставщика

        // Отображаем все элементы главной формы, кроме самой панели addVendorPanel
        foreach (Control control in Controls)
        {
            if (control != addVendorPanel)
                control.Visible = true;
        }
    }
}