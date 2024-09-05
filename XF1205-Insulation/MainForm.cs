namespace XF1205_Insulation;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void btnNewTest_Click(object sender, EventArgs e)
    {
        Form formNewTest = new TestRecordForm();
        formNewTest.ShowDialog();
    }

    private void btnQuit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnAbout_Click(object sender, EventArgs e)
    {
        Form dlgAbout = new AboutDialog();
        dlgAbout.ShowDialog();
    }
}
