namespace Tyuiu.KalininaMA.Sprint6.Task1.V16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KMA));
            groupBoxTask_KMA = new GroupBox();
            textBoxInPutData_KMA = new TextBox();
            groupBoxOutPutData_KMA = new GroupBox();
            textBoxResult_KMA = new TextBox();
            label1 = new Label();
            groupBoxInPutData_KMA = new GroupBox();
            textBoxStopValue_KMA = new TextBox();
            textBoxStartValue_KMA = new TextBox();
            labelStopValue_BMS = new Label();
            labelStartValue_KMA = new Label();
            buttonHelp_KMA = new Button();
            buttonPushMe_KMA = new Button();
            groupBoxTask_KMA.SuspendLayout();
            groupBoxOutPutData_KMA.SuspendLayout();
            groupBoxInPutData_KMA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KMA
            // 
            groupBoxTask_KMA.Controls.Add(textBoxInPutData_KMA);
            groupBoxTask_KMA.Location = new Point(19, 23);
            groupBoxTask_KMA.Name = "groupBoxTask_KMA";
            groupBoxTask_KMA.Size = new Size(362, 267);
            groupBoxTask_KMA.TabIndex = 0;
            groupBoxTask_KMA.TabStop = false;
            groupBoxTask_KMA.Text = "Условие";
            // 
            // textBoxInPutData_KMA
            // 
            textBoxInPutData_KMA.Location = new Point(12, 29);
            textBoxInPutData_KMA.Multiline = true;
            textBoxInPutData_KMA.Name = "textBoxInPutData_KMA";
            textBoxInPutData_KMA.ReadOnly = true;
            textBoxInPutData_KMA.Size = new Size(312, 222);
            textBoxInPutData_KMA.TabIndex = 0;
            textBoxInPutData_KMA.Text = resources.GetString("textBoxInPutData_KMA.Text");
            // 
            // groupBoxOutPutData_KMA
            // 
            groupBoxOutPutData_KMA.Controls.Add(textBoxResult_KMA);
            groupBoxOutPutData_KMA.Controls.Add(label1);
            groupBoxOutPutData_KMA.Location = new Point(401, 23);
            groupBoxOutPutData_KMA.Name = "groupBoxOutPutData_KMA";
            groupBoxOutPutData_KMA.Size = new Size(252, 381);
            groupBoxOutPutData_KMA.TabIndex = 1;
            groupBoxOutPutData_KMA.TabStop = false;
            groupBoxOutPutData_KMA.Text = "Вывод данных:";
            // 
            // textBoxResult_KMA
            // 
            textBoxResult_KMA.BackColor = SystemColors.Control;
            textBoxResult_KMA.Cursor = Cursors.IBeam;
            textBoxResult_KMA.Font = new Font("Consolas", 10F);
            textBoxResult_KMA.Location = new Point(6, 49);
            textBoxResult_KMA.Multiline = true;
            textBoxResult_KMA.Name = "textBoxResult_KMA";
            textBoxResult_KMA.ReadOnly = true;
            textBoxResult_KMA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KMA.Size = new Size(240, 326);
            textBoxResult_KMA.TabIndex = 1;
            textBoxResult_KMA.TextChanged += textBoxResult_KMA_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Результат:";
            // 
            // groupBoxInPutData_KMA
            // 
            groupBoxInPutData_KMA.Controls.Add(textBoxStopValue_KMA);
            groupBoxInPutData_KMA.Controls.Add(textBoxStartValue_KMA);
            groupBoxInPutData_KMA.Controls.Add(labelStopValue_BMS);
            groupBoxInPutData_KMA.Controls.Add(labelStartValue_KMA);
            groupBoxInPutData_KMA.Location = new Point(31, 304);
            groupBoxInPutData_KMA.Name = "groupBoxInPutData_KMA";
            groupBoxInPutData_KMA.Size = new Size(218, 100);
            groupBoxInPutData_KMA.TabIndex = 2;
            groupBoxInPutData_KMA.TabStop = false;
            groupBoxInPutData_KMA.Text = "Ввод данных:";
            // 
            // textBoxStopValue_KMA
            // 
            textBoxStopValue_KMA.Location = new Point(112, 39);
            textBoxStopValue_KMA.Name = "textBoxStopValue_KMA";
            textBoxStopValue_KMA.Size = new Size(88, 23);
            textBoxStopValue_KMA.TabIndex = 3;
            textBoxStopValue_KMA.Text = "5";
            // 
            // textBoxStartValue_KMA
            // 
            textBoxStartValue_KMA.Location = new Point(5, 39);
            textBoxStartValue_KMA.Name = "textBoxStartValue_KMA";
            textBoxStartValue_KMA.Size = new Size(86, 23);
            textBoxStartValue_KMA.TabIndex = 2;
            textBoxStartValue_KMA.Text = "-5";
            // 
            // labelStopValue_BMS
            // 
            labelStopValue_BMS.AutoSize = true;
            labelStopValue_BMS.Location = new Point(117, 19);
            labelStopValue_BMS.Name = "labelStopValue_BMS";
            labelStopValue_BMS.Size = new Size(75, 15);
            labelStopValue_BMS.TabIndex = 1;
            labelStopValue_BMS.Text = "Конец шага:";
            // 
            // labelStartValue_KMA
            // 
            labelStartValue_KMA.AutoSize = true;
            labelStartValue_KMA.Location = new Point(6, 19);
            labelStartValue_KMA.Name = "labelStartValue_KMA";
            labelStartValue_KMA.Size = new Size(72, 15);
            labelStartValue_KMA.TabIndex = 0;
            labelStartValue_KMA.Text = "Старт шага:";
            // 
            // buttonHelp_KMA
            // 
            buttonHelp_KMA.Location = new Point(255, 304);
            buttonHelp_KMA.Name = "buttonHelp_KMA";
            buttonHelp_KMA.Size = new Size(35, 94);
            buttonHelp_KMA.TabIndex = 3;
            buttonHelp_KMA.Text = "?";
            buttonHelp_KMA.UseVisualStyleBackColor = true;
            buttonHelp_KMA.Click += buttonHelp_KMA_Click;
            // 
            // buttonPushMe_KMA
            // 
            buttonPushMe_KMA.Location = new Point(296, 304);
            buttonPushMe_KMA.Name = "buttonPushMe_KMA";
            buttonPushMe_KMA.Size = new Size(85, 94);
            buttonPushMe_KMA.TabIndex = 4;
            buttonPushMe_KMA.Text = "Выполнить";
            buttonPushMe_KMA.UseVisualStyleBackColor = true;
            buttonPushMe_KMA.Click += buttonPushMe_KMA_Click;
            // 
            // FormMain_KMA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 431);
            Controls.Add(buttonPushMe_KMA);
            Controls.Add(buttonHelp_KMA);
            Controls.Add(groupBoxInPutData_KMA);
            Controls.Add(groupBoxOutPutData_KMA);
            Controls.Add(groupBoxTask_KMA);
            Name = "FormMain_KMA";
            Text = "Спринт 6 | Таск 1 | Вариант 16 | Калинина М.А";
            groupBoxTask_KMA.ResumeLayout(false);
            groupBoxTask_KMA.PerformLayout();
            groupBoxOutPutData_KMA.ResumeLayout(false);
            groupBoxOutPutData_KMA.PerformLayout();
            groupBoxInPutData_KMA.ResumeLayout(false);
            groupBoxInPutData_KMA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KMA;
        private TextBox textBoxInPutData_KMA;
        private GroupBox groupBoxOutPutData_KMA;
        private TextBox textBoxResult_KMA;
        private Label label1;
        private GroupBox groupBoxInPutData_KMA;
        private TextBox textBoxStopValue_KMA;
        private TextBox textBoxStartValue_KMA;
        private Label labelStopValue_BMS;
        private Label labelStartValue_KMA;
        private Button buttonHelp_KMA;
        private Button buttonPushMe_KMA;
    }
}
