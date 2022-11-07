namespace NiechlujnyJanek
{
    public partial class Form1 : Form
    {
        MenuMaker menu = new MenuMaker();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(menu.GetMenuItem(),"Twój dzisiejszy posi³ek...");
        }
    }
}