namespace BankFun
{
    public partial class Form1 : Form
    {
        int Bank = 100;
        Guy[] guy = new Guy[] { 
            new Guy("Joe", 50),
            new Guy("Bob",100),
            new Guy("Mark", 250),
            new Guy("Walter", 400),
            new Guy("Gus", 300),
            new Guy("Trevor", 150)
        };
        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i < guy.Length; i++)
            {
                this.Facet.Items.Add(guy[i].getName());
            }
            this.BankLbl.Text = "Bank ma aktualnie " + Bank + "z³";
        }

        private void Facet_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cash.Enabled = true;
            this.Cash.Maximum = guy[this.Facet.SelectedIndex].GetCash();
            this.Cash.Value = guy[this.Facet.SelectedIndex].GetCash() / 5;
            this.Wplata.Enabled = true;
            this.GuyCash.Text = guy[this.Facet.SelectedIndex].getName() + " ma " + guy[this.Facet.SelectedIndex].GetCash() + "z³";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GuyCash.Text = guy[this.Facet.SelectedIndex].Withdraw((int)this.Cash.Value);
            Bank -= (int)this.Cash.Value;
            this.BankLbl.Text = "Bank ma aktualnie " + Bank + "z³";
            this.Cash.Value = guy[this.Facet.SelectedIndex].GetCash() / 5;
            this.Cash.Maximum = guy[this.Facet.SelectedIndex].GetCash();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.GuyCash.Text = guy[this.Facet.SelectedIndex].Deposit((int)this.Cash.Value);
            Bank += (int)this.Cash.Value;
            this.BankLbl.Text = "Bank ma aktualnie " + Bank + "z³";
            this.Cash.Value = guy[this.Facet.SelectedIndex].GetCash() / 5;
            this.Cash.Maximum = guy[this.Facet.SelectedIndex].GetCash();
        }

        private void Cash_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            if (num.Value <= Bank)
            {
                Wyplata.Enabled = true;
            }
            else
            {
                Wyplata.Enabled = false;
            }
        }
    }
}