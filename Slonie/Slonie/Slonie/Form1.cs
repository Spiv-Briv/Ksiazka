namespace Slonie
{
    public partial class Form1 : Form
    {
        Elephant llo = new Elephant("Lloyd", 40);
        Elephant luc = new Elephant("Lucinda", 35);
        public Form1()
        {
            InitializeComponent();
            
            
        }
        private void Lloyd_Click(object sender, EventArgs e)
        {
            llo.WhoAmI();
        }
        private void Lucinda_Click(object sender, EventArgs e)
        {
            luc.WhoAmI();
        }
        private void ChangeElephants(object sender, EventArgs e)
        {
            Elephant buf = llo;
            llo = luc;
            luc = buf;
            MessageBox.Show("Obiekty zamienione");
        }
    }
}