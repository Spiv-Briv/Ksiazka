namespace ZmienTekstForm
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.chBox = new System.Windows.Forms.CheckBox();
            this.Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kliknięcie zmienia etykietę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chBox
            // 
            this.chBox.AutoSize = true;
            this.chBox.Checked = true;
            this.chBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBox.Location = new System.Drawing.Point(324, 12);
            this.chBox.Name = "chBox";
            this.chBox.Size = new System.Drawing.Size(148, 19);
            this.chBox.TabIndex = 1;
            this.chBox.Text = "Włącza zmianę etykiety";
            this.chBox.UseVisualStyleBackColor = true;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(22, 67);
            this.Label.MinimumSize = new System.Drawing.Size(450, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(450, 15);
            this.Label.TabIndex = 2;
            this.Label.Text = "Naciśnij przycisk, aby zmienić tekst";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 91);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.chBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Zmień tekst, ale to formularz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private CheckBox chBox;
        private Label Label;
    }
}