namespace MessageBox
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
            this.Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Times = new System.Windows.Forms.NumericUpDown();
            this.Output = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Times)).BeginInit();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(118, 12);
            this.Input.Name = "Input";
            this.Input.PlaceholderText = "Wiadomość wyjściowa";
            this.Input.Size = new System.Drawing.Size(300, 23);
            this.Input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Powiedz to: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Powtórz: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Times
            // 
            this.Times.Location = new System.Drawing.Point(118, 41);
            this.Times.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(120, 23);
            this.Times.TabIndex = 3;
            this.Times.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(200, 70);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(100, 23);
            this.Output.TabIndex = 4;
            this.Output.Text = "Mów!";
            this.Output.UseVisualStyleBackColor = true;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 111);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Times);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "MessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.Times)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Input;
        private Label label1;
        private Label label2;
        private NumericUpDown Times;
        private Button Output;
    }
}