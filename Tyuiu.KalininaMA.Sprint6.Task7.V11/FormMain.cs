using System.Windows.Forms;
using Tyuiu.KalininaMA.Sprint6.Task7.V11.Lib;
namespace Tyuiu.KalininaMA.Sprint6.Task7.V11
{
    public partial class FormMain : Form
    {
        static string openFilePath;
        static int rows;
        static int columns;
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string FilePath)
        {
            string fileData = File.ReadAllText(FilePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(line[j]);
                }
            }
            return matrix;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] matrix = new int[rows, columns];

            matrix = LoadFromFileData(openFilePath);

            dataGridViewInput.ColumnCount = columns;
            dataGridViewInput.RowCount = rows;
            dataGridViewOut.ColumnCount = columns;
            dataGridViewOut.RowCount = rows;

            for (int h = 0; h < columns; h++)
            {
                dataGridViewInput.Columns[h].Width = 35;
                dataGridViewOut.Columns[h].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInput.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            buttonRes.Enabled = true;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[rows, columns];
            matrix = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            buttonSave.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
