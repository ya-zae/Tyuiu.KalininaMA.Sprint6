namespace Tyuiu.KalininaMA.Sprint6.Task7.V11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonHelp = new Button();
            Task_KMA = new GroupBox();
            textBox1 = new TextBox();
            buttonSave = new Button();
            buttonRes = new Button();
            buttonLoad = new Button();
            groupBox1 = new GroupBox();
            dataGridViewInput = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridViewOut = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            panel1.SuspendLayout();
            Task_KMA.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(Task_KMA);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonRes);
            panel1.Controls.Add(buttonLoad);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 127);
            panel1.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(684, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 39);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // Task_KMA
            // 
            Task_KMA.Controls.Add(textBox1);
            Task_KMA.Location = new Point(6, 57);
            Task_KMA.Name = "Task_KMA";
            Task_KMA.Size = new Size(764, 67);
            Task_KMA.TabIndex = 3;
            Task_KMA.TabStop = false;
            Task_KMA.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(741, 42);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(203, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 38);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonRes
            // 
            buttonRes.Location = new Point(115, 13);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(82, 38);
            buttonRes.TabIndex = 1;
            buttonRes.Text = "Результат";
            buttonRes.UseVisualStyleBackColor = true;
            buttonRes.Click += buttonRes_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(6, 13);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(103, 38);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Загрузить";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewInput);
            groupBox1.Location = new Point(12, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 312);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод";
            // 
            // dataGridViewInput
            // 
            dataGridViewInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput.Location = new Point(6, 22);
            dataGridViewInput.Name = "dataGridViewInput";
            dataGridViewInput.Size = new Size(379, 275);
            dataGridViewInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewOut);
            groupBox2.Location = new Point(416, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 312);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(6, 22);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.Size = new Size(360, 276);
            dataGridViewOut.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            Task_KMA.ResumeLayout(false);
            Task_KMA.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private DataGridView dataGridViewInput;
        private GroupBox groupBox2;
        private DataGridView dataGridViewOut;
        private Button buttonHelp;
        private GroupBox Task_KMA;
        private Button buttonSave;
        private Button buttonRes;
        private Button buttonLoad;
        private TextBox textBox1;
        private OpenFileDialog openFileDialogTask;
    }
}
