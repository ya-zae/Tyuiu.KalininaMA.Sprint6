namespace Tyuiu.KalininaMA.Sprint6.Task3.V19
{
    partial class FormMain_KMA
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
            groupBoxConditionTask3_KMA = new GroupBox();
            textBox1 = new TextBox();
            dataGridViewMatrixTask3_KMA = new DataGridView();
            groupBoxOutputDataTask3_DAA = new GroupBox();
            buttoneResultTask3_KMA = new Button();
            buttonHelpTask3_KMA = new Button();
            textBoxOutputDataTask3_KMA = new TextBox();
            dataGridViewMatrixRTask3_KMA = new DataGridView();
            groupBoxConditionTask3_KMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixTask3_KMA).BeginInit();
            groupBoxOutputDataTask3_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixRTask3_KMA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxConditionTask3_KMA
            // 
            groupBoxConditionTask3_KMA.Controls.Add(textBox1);
            groupBoxConditionTask3_KMA.Controls.Add(dataGridViewMatrixTask3_KMA);
            groupBoxConditionTask3_KMA.Location = new Point(20, 24);
            groupBoxConditionTask3_KMA.Name = "groupBoxConditionTask3_KMA";
            groupBoxConditionTask3_KMA.Size = new Size(498, 414);
            groupBoxConditionTask3_KMA.TabIndex = 0;
            groupBoxConditionTask3_KMA.TabStop = false;
            groupBoxConditionTask3_KMA.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 51);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(219, 190);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дана матрица 5 на 5:4  32 -20  27  21\r\n\r\n  17  15  -1  -2  -1\r\n\r\n  -3  18  12 -10  29\r\n\r\n   7 -15   2  -8  12\r\n\r\n -10  25   5  27  21\r\n\r\nВыполнить сортировку по возрастанию в пятом столбце.\r\n\r\n";
            // 
            // dataGridViewMatrixTask3_KMA
            // 
            dataGridViewMatrixTask3_KMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixTask3_KMA.Location = new Point(251, 51);
            dataGridViewMatrixTask3_KMA.Name = "dataGridViewMatrixTask3_KMA";
            dataGridViewMatrixTask3_KMA.Size = new Size(241, 292);
            dataGridViewMatrixTask3_KMA.TabIndex = 0;
            // 
            // groupBoxOutputDataTask3_DAA
            // 
            groupBoxOutputDataTask3_DAA.Controls.Add(buttoneResultTask3_KMA);
            groupBoxOutputDataTask3_DAA.Controls.Add(buttonHelpTask3_KMA);
            groupBoxOutputDataTask3_DAA.Controls.Add(textBoxOutputDataTask3_KMA);
            groupBoxOutputDataTask3_DAA.Controls.Add(dataGridViewMatrixRTask3_KMA);
            groupBoxOutputDataTask3_DAA.Location = new Point(518, 24);
            groupBoxOutputDataTask3_DAA.Name = "groupBoxOutputDataTask3_DAA";
            groupBoxOutputDataTask3_DAA.Size = new Size(262, 414);
            groupBoxOutputDataTask3_DAA.TabIndex = 1;
            groupBoxOutputDataTask3_DAA.TabStop = false;
            groupBoxOutputDataTask3_DAA.Text = "Вывод данных";
            // 
            // buttoneResultTask3_KMA
            // 
            buttoneResultTask3_KMA.BackColor = Color.PaleGreen;
            buttoneResultTask3_KMA.Location = new Point(104, 357);
            buttoneResultTask3_KMA.Name = "buttoneResultTask3_KMA";
            buttoneResultTask3_KMA.Size = new Size(97, 44);
            buttoneResultTask3_KMA.TabIndex = 3;
            buttoneResultTask3_KMA.Text = "Выполнить";
            buttoneResultTask3_KMA.UseVisualStyleBackColor = false;
            buttoneResultTask3_KMA.Click += button2_Click;
            // 
            // buttonHelpTask3_KMA
            // 
            buttonHelpTask3_KMA.BackColor = SystemColors.ActiveCaption;
            buttonHelpTask3_KMA.Location = new Point(33, 357);
            buttonHelpTask3_KMA.Name = "buttonHelpTask3_KMA";
            buttonHelpTask3_KMA.Size = new Size(56, 44);
            buttonHelpTask3_KMA.TabIndex = 2;
            buttonHelpTask3_KMA.Text = "?";
            buttonHelpTask3_KMA.UseVisualStyleBackColor = false;
            buttonHelpTask3_KMA.Click += buttonHelpTask3_KMA_Click;
            // 
            // textBoxOutputDataTask3_KMA
            // 
            textBoxOutputDataTask3_KMA.Location = new Point(6, 22);
            textBoxOutputDataTask3_KMA.Multiline = true;
            textBoxOutputDataTask3_KMA.Name = "textBoxOutputDataTask3_KMA";
            textBoxOutputDataTask3_KMA.ReadOnly = true;
            textBoxOutputDataTask3_KMA.Size = new Size(72, 23);
            textBoxOutputDataTask3_KMA.TabIndex = 1;
            textBoxOutputDataTask3_KMA.Text = "Результат";
            // 
            // dataGridViewMatrixRTask3_KMA
            // 
            dataGridViewMatrixRTask3_KMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixRTask3_KMA.Location = new Point(6, 51);
            dataGridViewMatrixRTask3_KMA.Name = "dataGridViewMatrixRTask3_KMA";
            dataGridViewMatrixRTask3_KMA.Size = new Size(250, 292);
            dataGridViewMatrixRTask3_KMA.TabIndex = 0;
            // 
            // FormMain_KMA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutputDataTask3_DAA);
            Controls.Add(groupBoxConditionTask3_KMA);
            Name = "FormMain_KMA";
            Text = "Спринт 6 | Таск 3 | Вариант 19 | Калинина М.А";
            Load += FormMain_KMA_Load;
            groupBoxConditionTask3_KMA.ResumeLayout(false);
            groupBoxConditionTask3_KMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixTask3_KMA).EndInit();
            groupBoxOutputDataTask3_DAA.ResumeLayout(false);
            groupBoxOutputDataTask3_DAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixRTask3_KMA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxConditionTask3_KMA;
        private DataGridView dataGridViewMatrixTask3_KMA;
        private GroupBox groupBoxOutputDataTask3_DAA;
        private DataGridView dataGridViewMatrixRTask3_KMA;
        private TextBox textBoxOutputDataTask3_KMA;
        private TextBox textBox1;
        private Button buttoneResultTask3_KMA;
        private Button buttonHelpTask3_KMA;
    }
}
