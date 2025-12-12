namespace Tyuiu.KalininaMA.Sprint6.Task5.V9
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dataGridViewResult_KMA = new DataGridView();
            buttonDone_KMA = new Button();
            buttonOpen_KMA = new Button();
            buttonHelp_KMA = new Button();
            chartResult_KMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KMA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_KMA).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(17, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(413, 71);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла InPutFileTask5V9.txt. Вывести в dataGridView.Дан список из чисел. Вывести все элементы, равные 0. Построить диаграмму по этим значениям.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewResult_KMA);
            groupBox2.Location = new Point(17, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(187, 312);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // dataGridViewResult_KMA
            // 
            dataGridViewResult_KMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_KMA.Location = new Point(9, 23);
            dataGridViewResult_KMA.Name = "dataGridViewResult_KMA";
            dataGridViewResult_KMA.Size = new Size(172, 283);
            dataGridViewResult_KMA.TabIndex = 5;
            dataGridViewResult_KMA.CellContentClick += dataGridViewResult_KMA_CellContentClick;
            // 
            // buttonDone_KMA
            // 
            buttonDone_KMA.Location = new Point(452, 31);
            buttonDone_KMA.Name = "buttonDone_KMA";
            buttonDone_KMA.Size = new Size(108, 90);
            buttonDone_KMA.TabIndex = 2;
            buttonDone_KMA.Text = "Выполнить";
            buttonDone_KMA.UseVisualStyleBackColor = true;
            buttonDone_KMA.Click += buttonDone_KMA_Click;
            // 
            // buttonOpen_KMA
            // 
            buttonOpen_KMA.Location = new Point(566, 31);
            buttonOpen_KMA.Name = "buttonOpen_KMA";
            buttonOpen_KMA.Size = new Size(108, 90);
            buttonOpen_KMA.TabIndex = 3;
            buttonOpen_KMA.Text = "Открыть файл";
            buttonOpen_KMA.UseVisualStyleBackColor = true;
            buttonOpen_KMA.Click += buttonOpen_KMA_Click;
            // 
            // buttonHelp_KMA
            // 
            buttonHelp_KMA.Location = new Point(680, 31);
            buttonHelp_KMA.Name = "buttonHelp_KMA";
            buttonHelp_KMA.Size = new Size(108, 90);
            buttonHelp_KMA.TabIndex = 4;
            buttonHelp_KMA.Text = "Справка";
            buttonHelp_KMA.UseVisualStyleBackColor = true;
            buttonHelp_KMA.Click += ButtonHelp_KMA_Click;
            // 
            // chartResult_KMA
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_KMA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult_KMA.Legends.Add(legend1);
            chartResult_KMA.Location = new Point(210, 132);
            chartResult_KMA.Name = "chartResult_KMA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_KMA.Series.Add(series1);
            chartResult_KMA.Size = new Size(578, 300);
            chartResult_KMA.TabIndex = 5;
            chartResult_KMA.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chartResult_KMA);
            Controls.Add(buttonHelp_KMA);
            Controls.Add(buttonOpen_KMA);
            Controls.Add(buttonDone_KMA);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 23 | Калинина М.А";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KMA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_KMA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button buttonDone_KMA;
        private Button buttonOpen_KMA;
        private Button buttonHelp_KMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_KMA;
        private DataGridView dataGridViewResult_KMA;
    }
}
