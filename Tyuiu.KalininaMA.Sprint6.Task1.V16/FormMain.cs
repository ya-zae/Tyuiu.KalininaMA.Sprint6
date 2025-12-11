using Tyuiu.KalininaMA.Sprint6.Task1.V16.Lib;
namespace Tyuiu.KalininaMA.Sprint6.Task1.V16
{
    public partial class FormMain_KMA : Form
    {
        public FormMain_KMA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonPushMe_KMA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_KMA.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_KMA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_KMA.Text = "";
                textBoxResult_KMA.AppendText("+---------+-----------+" + Environment.NewLine);
                textBoxResult_KMA.AppendText("|    X    |    f(x)   |" + Environment.NewLine);
                textBoxResult_KMA.AppendText("+---------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}    |  {1, 7:f2}  | ", startStep, valueArray[i]);
                    textBoxResult_KMA.AppendText(strLine + Environment.NewLine);
                    startStep++;


                }
                textBoxResult_KMA.AppendText("+---------+-----------+" + Environment.NewLine);

            }
            catch
            {

                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_KMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы РППб-25-1 Калинина Мария Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxResult_KMA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
