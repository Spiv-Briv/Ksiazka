namespace BankFun
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
            this.Facet = new System.Windows.Forms.ComboBox();
            this.GuyCash = new System.Windows.Forms.Label();
            this.Wyplata = new System.Windows.Forms.Button();
            this.Wplata = new System.Windows.Forms.Button();
            this.Cash = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BankLbl = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Button();
            this.PassGuy = new System.Windows.Forms.ComboBox();
            this.PassLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cash)).BeginInit();
            this.SuspendLayout();
            // 
            // Facet
            // 
            this.Facet.FormattingEnabled = true;
            this.Facet.Location = new System.Drawing.Point(12, 37);
            this.Facet.Name = "Facet";
            this.Facet.Size = new System.Drawing.Size(121, 23);
            this.Facet.TabIndex = 0;
            this.Facet.SelectedIndexChanged += new System.EventHandler(this.Facet_SelectedIndexChanged);
            // 
            // GuyCash
            // 
            this.GuyCash.AutoSize = true;
            this.GuyCash.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuyCash.Location = new System.Drawing.Point(12, 9);
            this.GuyCash.Name = "GuyCash";
            this.GuyCash.Size = new System.Drawing.Size(137, 25);
            this.GuyCash.TabIndex = 1;
            this.GuyCash.Text = "Wybierz osobę";
            // 
            // Wyplata
            // 
            this.Wyplata.Enabled = false;
            this.Wyplata.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Wyplata.Location = new System.Drawing.Point(12, 120);
            this.Wyplata.Name = "Wyplata";
            this.Wyplata.Size = new System.Drawing.Size(175, 100);
            this.Wyplata.TabIndex = 2;
            this.Wyplata.Text = "Wypłać z banku";
            this.Wyplata.UseVisualStyleBackColor = true;
            this.Wyplata.Click += new System.EventHandler(this.button1_Click);
            // 
            // Wplata
            // 
            this.Wplata.Enabled = false;
            this.Wplata.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Wplata.Location = new System.Drawing.Point(193, 120);
            this.Wplata.Name = "Wplata";
            this.Wplata.Size = new System.Drawing.Size(175, 100);
            this.Wplata.TabIndex = 3;
            this.Wplata.Text = "Wpłać do banku";
            this.Wplata.UseVisualStyleBackColor = true;
            this.Wplata.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cash
            // 
            this.Cash.Enabled = false;
            this.Cash.Location = new System.Drawing.Point(13, 91);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(120, 23);
            this.Cash.TabIndex = 4;
            this.Cash.ValueChanged += new System.EventHandler(this.Cash_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kwota do transferu";
            // 
            // BankLbl
            // 
            this.BankLbl.AutoSize = true;
            this.BankLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BankLbl.Location = new System.Drawing.Point(12, 223);
            this.BankLbl.Name = "BankLbl";
            this.BankLbl.Size = new System.Drawing.Size(41, 20);
            this.BankLbl.TabIndex = 6;
            this.BankLbl.Text = "Bank";
            // 
            // Pass
            // 
            this.Pass.Enabled = false;
            this.Pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pass.Location = new System.Drawing.Point(374, 120);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(175, 100);
            this.Pass.TabIndex = 7;
            this.Pass.Text = "Przekaż";
            this.Pass.UseVisualStyleBackColor = true;
            this.Pass.Click += new System.EventHandler(this.Pass_Click);
            // 
            // PassGuy
            // 
            this.PassGuy.FormattingEnabled = true;
            this.PassGuy.Location = new System.Drawing.Point(374, 91);
            this.PassGuy.Name = "PassGuy";
            this.PassGuy.Size = new System.Drawing.Size(175, 23);
            this.PassGuy.TabIndex = 8;
            this.PassGuy.SelectedIndexChanged += new System.EventHandler(this.PassGuy_SelectedIndexChanged);
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassLbl.Location = new System.Drawing.Point(374, 223);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(0, 20);
            this.PassLbl.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.PassGuy);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.BankLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.Wplata);
            this.Controls.Add(this.Wyplata);
            this.Controls.Add(this.GuyCash);
            this.Controls.Add(this.Facet);
            this.Name = "Form1";
            this.Text = "Bank";
            ((System.ComponentModel.ISupportInitialize)(this.Cash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox Facet;
        private Label GuyCash;
        private Button Wyplata;
        private Button Wplata;
        private NumericUpDown Cash;
        private Label label1;
        private Label BankLbl;
        private Button Pass;
        private ComboBox PassGuy;
        private Label PassLbl;
    }
}