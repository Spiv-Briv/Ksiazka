namespace Literki
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BottomLabel = new System.Windows.Forms.StatusStrip();
            this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.missedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.allLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.AccuracyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DifficultyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DifficultyBar = new System.Windows.Forms.ToolStripProgressBar();
            this.BottomLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 86.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 140;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(884, 161);
            this.listBox1.TabIndex = 0;
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BottomLabel
            // 
            this.BottomLabel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctLabel,
            this.missedLabel,
            this.allLabel,
            this.AccuracyLabel,
            this.DifficultyLabel,
            this.DifficultyBar});
            this.BottomLabel.Location = new System.Drawing.Point(0, 139);
            this.BottomLabel.Name = "BottomLabel";
            this.BottomLabel.Size = new System.Drawing.Size(884, 22);
            this.BottomLabel.SizingGrip = false;
            this.BottomLabel.TabIndex = 1;
            this.BottomLabel.Text = "statusStrip1";
            // 
            // correctLabel
            // 
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(93, 17);
            this.correctLabel.Text = "Prawidłowych: 0";
            // 
            // missedLabel
            // 
            this.missedLabel.Name = "missedLabel";
            this.missedLabel.Size = new System.Drawing.Size(58, 17);
            this.missedLabel.Text = "Błędów: 0";
            // 
            // allLabel
            // 
            this.allLabel.Name = "allLabel";
            this.allLabel.Size = new System.Drawing.Size(77, 17);
            this.allLabel.Text = "Wszystkich: 0";
            // 
            // AccuracyLabel
            // 
            this.AccuracyLabel.Name = "AccuracyLabel";
            this.AccuracyLabel.Size = new System.Drawing.Size(88, 17);
            this.AccuracyLabel.Text = "Dokładność 0%";
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(451, 17);
            this.DifficultyLabel.Spring = true;
            this.DifficultyLabel.Text = "Poziom trudności:";
            this.DifficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DifficultyBar
            // 
            this.DifficultyBar.Maximum = 800;
            this.DifficultyBar.Name = "DifficultyBar";
            this.DifficultyBar.Size = new System.Drawing.Size(100, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 161);
            this.Controls.Add(this.BottomLabel);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Gra w literki";
            this.BottomLabel.ResumeLayout(false);
            this.BottomLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip BottomLabel;
        private ToolStripStatusLabel correctLabel;
        private ToolStripStatusLabel missedLabel;
        private ToolStripStatusLabel allLabel;
        private ToolStripStatusLabel AccuracyLabel;
        private ToolStripStatusLabel DifficultyLabel;
        private ToolStripProgressBar DifficultyBar;
    }
}