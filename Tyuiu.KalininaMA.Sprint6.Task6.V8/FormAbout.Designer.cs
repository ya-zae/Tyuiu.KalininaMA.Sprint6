namespace Tyuiu.KalininaMA.Sprint6.Task6.V8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBox1 = new TextBox();
            buttonOK_KMA = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(399, 25);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 378);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonOK_KMA
            // 
            buttonOK_KMA.Location = new Point(567, 415);
            buttonOK_KMA.Name = "buttonOK_KMA";
            buttonOK_KMA.Size = new Size(75, 23);
            buttonOK_KMA.TabIndex = 1;
            buttonOK_KMA.Text = "Ok";
            buttonOK_KMA.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 450);
            Controls.Add(buttonOK_KMA);
            Controls.Add(textBox1);
            Name = "FormAbout";
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonOK_KMA;
    }
}