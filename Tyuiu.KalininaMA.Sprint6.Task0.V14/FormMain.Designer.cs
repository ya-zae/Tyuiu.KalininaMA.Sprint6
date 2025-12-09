
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
            groupBoxResult_KMA = new GroupBox();
            textBoxResult_KMA = new TextBox();
            ButtomDown_KMA = new Button();
            buttonQuestion_KMA = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxResult_KMA.SuspendLayout();
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
            // groupBoxResult_KMA
            // 
            groupBoxResult_KMA.Controls.Add(textBoxResult_KMA);
            groupBoxResult_KMA.Location = new Point(28, 241);
            groupBoxResult_KMA.Name = "groupBoxResult_KMA";
            groupBoxResult_KMA.Size = new Size(556, 115);
            groupBoxResult_KMA.TabIndex = 4;
            groupBoxResult_KMA.TabStop = false;
            groupBoxResult_KMA.Text = "Вывод данных";
            groupBoxResult_KMA.Enter += groupBoxResult_KMA_Enter;
            // 
            // textBoxResult_KMA
            // 
            textBoxResult_KMA.Cursor = Cursors.IBeam;
            textBoxResult_KMA.Location = new Point(9, 77);
            textBoxResult_KMA.Name = "textBoxResult_KMA";
            textBoxResult_KMA.ReadOnly = true;
            textBoxResult_KMA.Size = new Size(100, 23);
            textBoxResult_KMA.TabIndex = 2;
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
            buttonQuestion_KMA.Click += buttonQuestion_KMA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 450);
            Controls.Add(buttonQuestion_KMA);
            Controls.Add(groupBoxResult_KMA);
            Controls.Add(groupBox1);
            Controls.Add(ButtomDown_KMA);
            Name = "FormMain";
            Text = "Спринт6 | Таск 0 | Вариант 14 | Калинина.М.А ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxResult_KMA.ResumeLayout(false);
            groupBoxResult_KMA.PerformLayout();
            ResumeLayout(false);
        }

        private void ButtomDown_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            textBoxResult_KMA.Text = Convert.ToString(ds.Calculate(3));
        }


        private void textBoxIntX_KMA_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBoxResult_KMA;
        private TextBox textBoxResult_KMA;
        private Button ButtomDown_KMA;
        private Button buttonQuestion_KMA;
        private Label label1;
    }
}
