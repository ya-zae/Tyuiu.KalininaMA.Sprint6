namespace Tyuiu.KalininaMA.Sprint6.Task7.V11
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 166);
            textBox1.TabIndex = 0;
            textBox1.Text = "Разработчик:\r\nКалинина Мария Александровна \r\n\r\nГруппа:\r\nРППб-25-1\r\n\r\nСпринт 6 \r\nЗадание 7\r\nВариант 11\r\n\r\n";
            // 
            // buttonOk
            // 
            buttonOk.BackColor = Color.MediumSeaGreen;
            buttonOk.Location = new Point(196, 266);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 50);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 328);
            Controls.Add(buttonOk);
            Controls.Add(textBox1);
            Name = "FormAbout";
            Text = "Справка";
            Load += FormAbout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonOk;
    }
}