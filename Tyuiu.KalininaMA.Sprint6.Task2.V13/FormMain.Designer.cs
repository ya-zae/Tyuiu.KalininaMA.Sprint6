namespace Tyuiu.KalininaMA.Sprint6.Task2.V13
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_KMA = new GroupBox();
            textBoxTask_KMA = new TextBox();
            groupBoxResult_KMA = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            f = new DataGridViewTextBoxColumn();
            groupBoxStartStop_KMA = new GroupBox();
            buttonDone_KMA = new Button();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            textBoxStartStop_KMA = new TextBox();
            buttonQuestion_KMA = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBoxTask_KMA.SuspendLayout();
            groupBoxResult_KMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            groupBoxStartStop_KMA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KMA
            // 
            groupBoxTask_KMA.Controls.Add(textBoxTask_KMA);
            groupBoxTask_KMA.Location = new Point(18, 12);
            groupBoxTask_KMA.Name = "groupBoxTask_KMA";
            groupBoxTask_KMA.Size = new Size(390, 201);
            groupBoxTask_KMA.TabIndex = 0;
            groupBoxTask_KMA.TabStop = false;
            groupBoxTask_KMA.Text = "Условие:";
            // 
            // textBoxTask_KMA
            // 
            textBoxTask_KMA.Location = new Point(3, 20);
            textBoxTask_KMA.Multiline = true;
            textBoxTask_KMA.Name = "textBoxTask_KMA";
            textBoxTask_KMA.ReadOnly = true;
            textBoxTask_KMA.Size = new Size(381, 175);
            textBoxTask_KMA.TabIndex = 0;
            textBoxTask_KMA.Text = "Протабулировать функцию на заданном диапазоне. Ответ вывести в DataGridView и построить график функции.";
            // 
            // groupBoxResult_KMA
            // 
            groupBoxResult_KMA.Controls.Add(chartFunction);
            groupBoxResult_KMA.Controls.Add(dataGridViewFunction);
            groupBoxResult_KMA.Location = new Point(432, 12);
            groupBoxResult_KMA.Name = "groupBoxResult_KMA";
            groupBoxResult_KMA.Size = new Size(643, 313);
            groupBoxResult_KMA.TabIndex = 1;
            groupBoxResult_KMA.TabStop = false;
            groupBoxResult_KMA.Text = "Вывод данных: ";
            // 
            // chartFunction
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction.Legends.Add(legend2);
            chartFunction.Location = new Point(176, 20);
            chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction.Series.Add(series2);
            chartFunction.Size = new Size(446, 287);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chart1";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, f });
            dataGridViewFunction.Location = new Point(3, 21);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.Size = new Size(155, 286);
            dataGridViewFunction.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 75;
            // 
            // f
            // 
            f.HeaderText = "F(x)";
            f.Name = "f";
            f.Width = 75;
            // 
            // groupBoxStartStop_KMA
            // 
            groupBoxStartStop_KMA.Controls.Add(buttonDone_KMA);
            groupBoxStartStop_KMA.Controls.Add(textBoxStop);
            groupBoxStartStop_KMA.Controls.Add(textBoxStart);
            groupBoxStartStop_KMA.Controls.Add(textBoxStartStop_KMA);
            groupBoxStartStop_KMA.Location = new Point(17, 219);
            groupBoxStartStop_KMA.Name = "groupBoxStartStop_KMA";
            groupBoxStartStop_KMA.Size = new Size(391, 106);
            groupBoxStartStop_KMA.TabIndex = 2;
            groupBoxStartStop_KMA.TabStop = false;
            groupBoxStartStop_KMA.Text = "Ввод данных:";
            // 
            // buttonDone_KMA
            // 
            buttonDone_KMA.BackColor = Color.Green;
            buttonDone_KMA.Location = new Point(280, 22);
            buttonDone_KMA.Name = "buttonDone_KMA";
            buttonDone_KMA.Size = new Size(105, 78);
            buttonDone_KMA.TabIndex = 4;
            buttonDone_KMA.Text = "Выполнить";
            buttonDone_KMA.UseVisualStyleBackColor = false;
            buttonDone_KMA.Click += buttonDone_KMA_Click;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(115, 41);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(73, 23);
            textBoxStop.TabIndex = 3;
            textBoxStop.Text = "5";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(16, 41);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(73, 23);
            textBoxStart.TabIndex = 3;
            textBoxStart.Text = "-5";
            // 
            // textBoxStartStop_KMA
            // 
            textBoxStartStop_KMA.Location = new Point(6, 20);
            textBoxStartStop_KMA.Multiline = true;
            textBoxStartStop_KMA.Name = "textBoxStartStop_KMA";
            textBoxStartStop_KMA.ReadOnly = true;
            textBoxStartStop_KMA.Size = new Size(193, 80);
            textBoxStartStop_KMA.TabIndex = 0;
            textBoxStartStop_KMA.Text = "  Старт шага:           Конец шага:";
            // 
            // buttonQuestion_KMA
            // 
            buttonQuestion_KMA.BackColor = Color.Cyan;
            buttonQuestion_KMA.Location = new Point(222, 239);
            buttonQuestion_KMA.Name = "buttonQuestion_KMA";
            buttonQuestion_KMA.Size = new Size(69, 80);
            buttonQuestion_KMA.TabIndex = 3;
            buttonQuestion_KMA.Text = "Справка";
            buttonQuestion_KMA.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 337);
            Controls.Add(buttonQuestion_KMA);
            Controls.Add(groupBoxStartStop_KMA);
            Controls.Add(groupBoxResult_KMA);
            Controls.Add(groupBoxTask_KMA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 13 | Калинина М.А";
            groupBoxTask_KMA.ResumeLayout(false);
            groupBoxTask_KMA.PerformLayout();
            groupBoxResult_KMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            groupBoxStartStop_KMA.ResumeLayout(false);
            groupBoxStartStop_KMA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KMA;
        private GroupBox groupBoxResult_KMA;
        private DataGridView dataGridViewFunction;
        private GroupBox groupBoxStartStop_KMA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn f;
        private TextBox textBoxTask_KMA;
        private TextBox textBoxStartStop_KMA;
        private Button buttonDone_KMA;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private Button buttonQuestion_KMA;
        private ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
