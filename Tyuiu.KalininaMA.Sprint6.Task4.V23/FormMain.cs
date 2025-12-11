using Tyuiu.KalininaMA.Sprint6.Task4.V23.Lib;

namespace Tyuiu.KalininaMA.Sprint6.Task4.V23
{
    public partial class FormMain_KMA : Form
    {
        public FormMain_KMA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBoxStop_KMA = new TextBox();
            textBoxStart_KMA = new TextBox();
            StartStopValue = new Label();
            buttonDone_KMA = new Button();
            buttonSave_KMA = new Button();
            buttonQuestion_KMA = new Button();
            groupBox3 = new GroupBox();
            textBoxResult_KMA = new TextBox();
            chartFunction_KMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KMA).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(27, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 82);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 20);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(335, 56);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию на диапазоне. ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxStop_KMA);
            groupBox2.Controls.Add(textBoxStart_KMA);
            groupBox2.Controls.Add(StartStopValue);
            groupBox2.Controls.Add(buttonDone_KMA);
            groupBox2.Controls.Add(buttonSave_KMA);
            groupBox2.Controls.Add(buttonQuestion_KMA);
            groupBox2.Location = new Point(382, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(481, 82);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных:";
            // 
            // textBoxStop_KMA
            // 
            textBoxStop_KMA.Location = new Point(96, 37);
            textBoxStop_KMA.Name = "textBoxStop_KMA";
            textBoxStop_KMA.Size = new Size(77, 23);
            textBoxStop_KMA.TabIndex = 7;
            textBoxStop_KMA.Text = "5";
            // 
            // textBoxStart_KMA
            // 
            textBoxStart_KMA.Location = new Point(6, 37);
            textBoxStart_KMA.Name = "textBoxStart_KMA";
            textBoxStart_KMA.Size = new Size(77, 23);
            textBoxStart_KMA.TabIndex = 6;
            textBoxStart_KMA.Text = "-5";
            // 
            // StartStopValue
            // 
            StartStopValue.AutoSize = true;
            StartStopValue.Location = new Point(6, 19);
            StartStopValue.Name = "StartStopValue";
            StartStopValue.Size = new Size(167, 15);
            StartStopValue.TabIndex = 5;
            StartStopValue.Text = "Старт шага:         Конец шага:";
            // 
            // buttonDone_KMA
            // 
            buttonDone_KMA.BackColor = Color.LimeGreen;
            buttonDone_KMA.Location = new Point(211, 16);
            buttonDone_KMA.Name = "buttonDone_KMA";
            buttonDone_KMA.Size = new Size(86, 60);
            buttonDone_KMA.TabIndex = 2;
            buttonDone_KMA.Text = "Выполнить";
            buttonDone_KMA.UseVisualStyleBackColor = false;
            buttonDone_KMA.Click += buttonDone_KMA_Click;
            // 
            // buttonSave_KMA
            // 
            buttonSave_KMA.BackColor = Color.RoyalBlue;
            buttonSave_KMA.Location = new Point(303, 16);
            buttonSave_KMA.Name = "buttonSave_KMA";
            buttonSave_KMA.Size = new Size(86, 60);
            buttonSave_KMA.TabIndex = 3;
            buttonSave_KMA.Text = "Сохранить";
            buttonSave_KMA.UseVisualStyleBackColor = false;
            buttonSave_KMA.Click += buttonSave_KMA_Click;
            // 
            // buttonQuestion_KMA
            // 
            buttonQuestion_KMA.BackColor = SystemColors.ActiveCaption;
            buttonQuestion_KMA.Location = new Point(395, 16);
            buttonQuestion_KMA.Name = "buttonQuestion_KMA";
            buttonQuestion_KMA.Size = new Size(80, 60);
            buttonQuestion_KMA.TabIndex = 4;
            buttonQuestion_KMA.Text = "Справка";
            buttonQuestion_KMA.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult_KMA);
            groupBox3.Location = new Point(28, 116);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(205, 379);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод:";
            // 
            // textBoxResult_KMA
            // 
            textBoxResult_KMA.Location = new Point(8, 24);
            textBoxResult_KMA.Multiline = true;
            textBoxResult_KMA.Name = "textBoxResult_KMA";
            textBoxResult_KMA.ReadOnly = true;
            textBoxResult_KMA.Size = new Size(191, 349);
            textBoxResult_KMA.TabIndex = 0;
            // 
            // chartFunction_KMA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KMA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_KMA.Legends.Add(legend1);
            chartFunction_KMA.Location = new Point(252, 116);
            chartFunction_KMA.Name = "chartFunction_KMA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_KMA.Series.Add(series1);
            chartFunction_KMA.Size = new Size(599, 379);
            chartFunction_KMA.TabIndex = 6;
            chartFunction_KMA.Text = "График";
            // 
            // FormMain_KMA
            // 
            ClientSize = new Size(872, 507);
            Controls.Add(chartFunction_KMA);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain_KMA";
            Text = "Спринт 6 | Таск 4 | Вариант 23 | Калинина М.А";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KMA).EndInit();
            ResumeLayout(false);

        }
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonDone_KMA;
        private Button buttonSave_KMA;
        private Button buttonQuestion_KMA;
        private GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KMA;
        private TextBox textBoxStop_KMA;
        private TextBox textBoxStart_KMA;
        private Label StartStopValue;
        private TextBox textBox1;
        private TextBox textBoxResult_KMA;

        private void buttonDone_KMA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KMA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_KMA.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_KMA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KMA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_KMA.Text = "";

                chartFunction_KMA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    chartFunction_KMA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_KMA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_KMA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V23.txt";
                File.WriteAllText(path, textBoxResult_KMA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " успешно сохранён\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
