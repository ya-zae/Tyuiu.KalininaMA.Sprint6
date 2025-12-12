using System.IO;
using Tyuiu.KalininaMA.Sprint6.Task5.V9.Lib;

namespace Tyuiu.KalininaMA.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\User\source\repos\Tyuiu.KalininaMA.Sprint6\Tyuiu.KalininaMA.Sprint6.Task5.V9\bin\Debug\InPutDataFileTask5V9.txt";


        private void buttonDone_KMA_Click(object sender, EventArgs e)
        {
            dataGridViewResult_KMA.ColumnCount = 2;
            dataGridViewResult_KMA.Columns[0].Width = 20;
            dataGridViewResult_KMA.Columns[1].Width = 50;

            this.chartResult_KMA.ChartAreas[0].AxisX.Title = "Int X";
            this.chartResult_KMA.ChartAreas[0].AxisY.Title = "Int Y";

            chartResult_KMA.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_KMA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_KMA.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void textBoxResult_KMA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpen_KMA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void ButtonHelp_KMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы РППб-25-1 Калинина Мария Александровна", "Сообщение");
        }

        private void dataGridViewResult_KMA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
