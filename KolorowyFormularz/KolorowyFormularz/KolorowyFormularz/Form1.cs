namespace KolorowyFormularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            bool ch = true;
            while (Visible)
            {
                this.BackColor = Color.FromArgb(c, 255 - c, c);
                if (ch) { c++; }
                else
                {
                    c--;
                }
                if(c == 254)
                {
                    ch = false;
                }
                if (c == 0) { ch = true; }
                Application.DoEvents();
                System.Threading.Thread.Sleep(2);
            }
        }
    }
}