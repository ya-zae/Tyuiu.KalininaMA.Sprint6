using Tyuiu.KalininaMA.Sprint6.Task3.V19.Lib;
namespace Tyuiu.KalininaMA.Sprint6.Task3.V19
{
    public partial class FormMain_KMA : Form
    {
        public FormMain_KMA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { { 4, 32, -20, 27 , 21},
                                      { 17, 15, -1, -2 , -1},
                                      { -3, 18, 12, -10 , 29},
                                      { 7, -15, 2, -8 , 12},
                                      { -10, 25, 5, 27 , 21} };


        private void button2_Click(object sender, EventArgs e)
        {
            int[,] resArray = ds.Calculate(mtrx);
            int rowss = resArray.GetUpperBound(0) + 1;
            int columnss = resArray.Length / rowss;

            dataGridViewMatrixRTask3_KMA.ColumnCount = columnss;
            dataGridViewMatrixRTask3_KMA.RowCount = rowss;

            for (int i = 0; i < columnss; i++)
            {
                dataGridViewMatrixRTask3_KMA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rowss; i++)
            {
                for (int j = 0; j < columnss; j++)
                {
                    dataGridViewMatrixRTask3_KMA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void FormMain_KMA_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrixTask3_KMA.ColumnCount = columns;
            dataGridViewMatrixTask3_KMA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixTask3_KMA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixTask3_KMA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonHelpTask3_KMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студентка группы РППб-25-1 Калинина Мария Александровна", "Сообщение");
        }
    }
}
