using Tyuiu.KalininaMA.Sprint6.Task0.V14.Lib;

namespace Tyuiu.KalininaMA.Sprint6.Task0.V14
{
    public partial class FormMain : Form
    {
        private object textBoxIntX_KMA;

        public FormMain()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_KMA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                textBoxResult_KMA.Text = Convert.ToString(ds.Calculate(x: Convert.ToInt32(textBoxIntX_KMA)));
            }


            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxIntX_KMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxResult_KMA_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuestion_KMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы РППб-25-1 Бородулин Матвей Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBoxResult_KMA_Enter(object sender, EventArgs e)
        {

        }
    }
}
