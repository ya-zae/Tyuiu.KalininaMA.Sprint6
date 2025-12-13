namespace Tyuiu.KalininaMA.Sprint6.Task6.V8
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KMA));
            panelTopTop_KMA = new Panel();
            buttonHelp_KMA = new Button();
            buttonDone_KMA = new Button();
            buttonOpen_KMA = new Button();
            groupBoxTerm_KMA = new GroupBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            textBoxInPut_KMA = new TextBox();
            groupBoxOutPut_KMA = new GroupBox();
            textBoxResult_KMA = new TextBox();
            openFileDialogTask_KMA = new OpenFileDialog();
            toolTip_KMA = new ToolTip(components);
            panelTopTop_KMA.SuspendLayout();
            groupBoxTerm_KMA.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxOutPut_KMA.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopTop_KMA
            // 
            panelTopTop_KMA.Controls.Add(buttonHelp_KMA);
            panelTopTop_KMA.Controls.Add(buttonDone_KMA);
            panelTopTop_KMA.Controls.Add(buttonOpen_KMA);
            panelTopTop_KMA.Location = new Point(12, 16);
            panelTopTop_KMA.Name = "panelTopTop_KMA";
            panelTopTop_KMA.Size = new Size(776, 73);
            panelTopTop_KMA.TabIndex = 0;
            // 
            // buttonHelp_KMA
            // 
            buttonHelp_KMA.Location = new Point(662, 8);
            buttonHelp_KMA.Name = "buttonHelp_KMA";
            buttonHelp_KMA.Size = new Size(84, 57);
            buttonHelp_KMA.TabIndex = 2;
            buttonHelp_KMA.Text = "button3";
            buttonHelp_KMA.UseVisualStyleBackColor = true;
            buttonHelp_KMA.Click += buttonHelp_KMA_Click;
            // 
            // buttonDone_KMA
            // 
            buttonDone_KMA.Location = new Point(115, 8);
            buttonDone_KMA.Name = "buttonDone_KMA";
            buttonDone_KMA.Size = new Size(82, 57);
            buttonDone_KMA.TabIndex = 1;
            buttonDone_KMA.Text = "button2";
            buttonDone_KMA.UseVisualStyleBackColor = true;
            buttonDone_KMA.Click += buttonDone_KMA_Click;
            // 
            // buttonOpen_KMA
            // 
            buttonOpen_KMA.Location = new Point(14, 8);
            buttonOpen_KMA.Name = "buttonOpen_KMA";
            buttonOpen_KMA.Size = new Size(82, 57);
            buttonOpen_KMA.TabIndex = 0;
            buttonOpen_KMA.Text = "button1";
            buttonOpen_KMA.UseVisualStyleBackColor = true;
            buttonOpen_KMA.Click += buttonOpen_KMA_Click;
            // 
            // groupBoxTerm_KMA
            // 
            groupBoxTerm_KMA.Controls.Add(textBox1);
            groupBoxTerm_KMA.Location = new Point(9, 95);
            groupBoxTerm_KMA.Name = "groupBoxTerm_KMA";
            groupBoxTerm_KMA.Size = new Size(779, 100);
            groupBoxTerm_KMA.TabIndex = 3;
            groupBoxTerm_KMA.TabStop = false;
            groupBoxTerm_KMA.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(770, 75);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxInPut_KMA);
            groupBox1.Location = new Point(12, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 237);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBoxInPut_KMA
            // 
            textBoxInPut_KMA.Location = new Point(6, 19);
            textBoxInPut_KMA.Multiline = true;
            textBoxInPut_KMA.Name = "textBoxInPut_KMA";
            textBoxInPut_KMA.ReadOnly = true;
            textBoxInPut_KMA.Size = new Size(388, 212);
            textBoxInPut_KMA.TabIndex = 0;
            textBoxInPut_KMA.TextChanged += textBoxInPut_KMA_TextChanged;
            // 
            // groupBoxOutPut_KMA
            // 
            groupBoxOutPut_KMA.Controls.Add(textBoxResult_KMA);
            groupBoxOutPut_KMA.Location = new Point(418, 201);
            groupBoxOutPut_KMA.Name = "groupBoxOutPut_KMA";
            groupBoxOutPut_KMA.Size = new Size(364, 237);
            groupBoxOutPut_KMA.TabIndex = 0;
            groupBoxOutPut_KMA.TabStop = false;
            groupBoxOutPut_KMA.Text = "Вывод:";
            // 
            // textBoxResult_KMA
            // 
            textBoxResult_KMA.Location = new Point(6, 19);
            textBoxResult_KMA.Multiline = true;
            textBoxResult_KMA.Name = "textBoxResult_KMA";
            textBoxResult_KMA.ReadOnly = true;
            textBoxResult_KMA.Size = new Size(352, 212);
            textBoxResult_KMA.TabIndex = 1;
            textBoxResult_KMA.TextChanged += textBoxResult_KMA_TextChanged;
            // 
            // openFileDialogTask_KMA
            // 
            openFileDialogTask_KMA.FileName = "openFileDialog1";
            // 
            // FormMain_KMA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutPut_KMA);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxTerm_KMA);
            Controls.Add(panelTopTop_KMA);
            Name = "FormMain_KMA";
            Text = "Спринт 6 | Таск 6 | Вариант 8 | Калинина М.А";
            panelTopTop_KMA.ResumeLayout(false);
            groupBoxTerm_KMA.ResumeLayout(false);
            groupBoxTerm_KMA.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxOutPut_KMA.ResumeLayout(false);
            groupBoxOutPut_KMA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopTop_KMA;
        private Button buttonOpen_KMA;
        private Button buttonHelp_KMA;
        private Button buttonDone_KMA;
        private GroupBox groupBoxTerm_KMA;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox textBoxInPut_KMA;
        private GroupBox groupBoxOutPut_KMA;
        private TextBox textBoxResult_KMA;
        private OpenFileDialog openFileDialogTask_KMA;
        private ToolTip toolTip_KMA;
    }
}
