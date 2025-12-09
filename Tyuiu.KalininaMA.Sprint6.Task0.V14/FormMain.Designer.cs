
using Tyuiu.KalininaMA.Sprint6.Task0.V14.Lib;

namespace Tyuiu.KalininaMA.Sprint6.Task0.V14
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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBoxIntX_KMA = new TextBox();
            groupBox3 = new GroupBox();
            textBoxResult_KMA = new TextBox();
            ButtomDown_KMA = new Button();
            buttonQuestion_KMA = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(355, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 84);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(206, 15);
            label1.TabIndex = 1;
            label1.Text = "Выполнить выражение по формуле";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxIntX_KMA);
            groupBox2.Location = new Point(28, 241);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 115);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBoxIntX_KMA
            // 
            textBoxIntX_KMA.Location = new Point(15, 77);
            textBoxIntX_KMA.Name = "textBoxIntX_KMA";
            textBoxIntX_KMA.Size = new Size(100, 23);
            textBoxIntX_KMA.TabIndex = 0;
            textBoxIntX_KMA.TextChanged += textBoxIntX_KMA_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult_KMA);
            groupBox3.Location = new Point(396, 241);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(188, 115);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBoxResult_KMA
            // 
            textBoxResult_KMA.Location = new Point(9, 77);
            textBoxResult_KMA.Name = "textBoxResult_KMA";
            textBoxResult_KMA.ReadOnly = true;
            textBoxResult_KMA.Size = new Size(100, 23);
            textBoxResult_KMA.TabIndex = 1;
            textBoxResult_KMA.TextChanged += textBoxResult_KMA_TextChanged;
            // 
            // ButtomDown_KMA
            // 
            ButtomDown_KMA.Location = new Point(496, 388);
            ButtomDown_KMA.Name = "ButtomDown_KMA";
            ButtomDown_KMA.Size = new Size(88, 37);
            ButtomDown_KMA.TabIndex = 5;
            ButtomDown_KMA.Text = "Выполнить";
            ButtomDown_KMA.UseVisualStyleBackColor = false;
            ButtomDown_KMA.Click += ButtomDown_Click;
            // 
            // buttonQuestion_KMA
            // 
            buttonQuestion_KMA.Location = new Point(455, 388);
            buttonQuestion_KMA.Name = "buttonQuestion_KMA";
            buttonQuestion_KMA.Size = new Size(35, 37);
            buttonQuestion_KMA.TabIndex = 6;
            buttonQuestion_KMA.Text = "?";
            buttonQuestion_KMA.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 450);
            Controls.Add(buttonQuestion_KMA);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ButtomDown_KMA);
            Name = "FormMain";
            Text = "Спринт6 | Таск 0 | Вариант 14 | Калинина.М.А ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        private void ButtomDown_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtomDown_KMA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                
                double x = Convert.ToDouble(textBoxIntX_KMA.Text);
                double result = ds.Calculate(x);
                textBoxResult_KMA.Text = result.ToString("F4");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textBoxIntX_KMA_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private TextBox textBoxIntX_KMA;
        private GroupBox groupBox3;
        private TextBox textBoxResult_KMA;
        private Button ButtomDown_KMA;
        private Button buttonQuestion_KMA;
    }
}
