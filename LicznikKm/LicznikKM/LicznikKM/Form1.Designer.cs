namespace LicznikKM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.NumericUpDown();
            this.Koniec = new System.Windows.Forms.NumericUpDown();
            this.Wartosc = new System.Windows.Forms.Label();
            this.Calc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Początkowy stan licznika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Końcowy stan licznika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kwota do zwrotu";
            // 
            // Start
            // 
            this.Start.Enabled = false;
            this.Start.Location = new System.Drawing.Point(155, 7);
            this.Start.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Start.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(120, 23);
            this.Start.TabIndex = 3;
            this.Start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Koniec
            // 
            this.Koniec.Location = new System.Drawing.Point(141, 45);
            this.Koniec.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Koniec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Koniec.Name = "Koniec";
            this.Koniec.Size = new System.Drawing.Size(120, 23);
            this.Koniec.TabIndex = 4;
            this.Koniec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Koniec.ValueChanged += new System.EventHandler(this.Koniec_ValueChanged);
            // 
            // Wartosc
            // 
            this.Wartosc.AutoSize = true;
            this.Wartosc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Wartosc.Location = new System.Drawing.Point(114, 80);
            this.Wartosc.Name = "Wartosc";
            this.Wartosc.Size = new System.Drawing.Size(48, 19);
            this.Wartosc.TabIndex = 5;
            this.Wartosc.Text = "0.00zł";
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(141, 109);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 6;
            this.Calc.Text = "Oblicz";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 144);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.Wartosc);
            this.Controls.Add(this.Koniec);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown Start;
        private NumericUpDown Koniec;
        private Label Wartosc;
        private Button Calc;
    }
}