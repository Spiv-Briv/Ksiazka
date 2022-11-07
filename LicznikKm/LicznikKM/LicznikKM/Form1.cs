namespace LicznikKM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kwota do zap³aty to: " + ((this.Koniec.Value-this.Start.Value)*(decimal)0.39) + "z³");
            this.Start.Value = this.Koniec.Value;
            this.Koniec.Minimum = this.Start.Value;
        }

        private void Koniec_ValueChanged(object sender, EventArgs e)
        {
            this.Wartosc.Text = ((this.Koniec.Value - this.Start.Value) * (decimal)0.39) + "z³";
        }
    }
}