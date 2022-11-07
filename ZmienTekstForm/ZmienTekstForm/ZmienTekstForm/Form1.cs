namespace ZmienTekstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.chBox.Checked == true)
            {
                if(this.Label.TextAlign == ContentAlignment.MiddleRight)
                {
                    this.Label.Text = "Z lewej";
                    this.Label.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    this.Label.Text = "Z prawej";
                    this.Label.TextAlign = ContentAlignment.MiddleRight;
                }
            }
            else
            {
                this.Label.Text = "Zmiana tekstu aktualnie wy³¹czona";
                this.Label.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}