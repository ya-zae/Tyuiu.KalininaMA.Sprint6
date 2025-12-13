using Tyuiu.KalininaMA.Sprint6.Task6.V8.Lib;
namespace Tyuiu.KalininaMA.Sprint6.Task6.V8
{
    public partial class FormMain_KMA : Form
    {
        public FormMain_KMA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;

        private void buttonOpen_KMA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KMA.ShowDialog();
            openFilePath = openFileDialogTask_KMA.FileName;
            textBoxInPut_KMA.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_KMA.Text = groupBoxOutPut_KMA + " " + openFileDialogTask_KMA.FileName;
            buttonDone_KMA.Enabled = true;
        }

        private void buttonDone_KMA_Click(object sender, EventArgs e)
        {
            textBoxResult_KMA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_KMA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxInPut_KMA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_KMA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
