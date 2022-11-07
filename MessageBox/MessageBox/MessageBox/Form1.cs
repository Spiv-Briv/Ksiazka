namespace MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int BlaBla(string text, int mul)
        {
            string end = "";
            for(int i = 0; i < mul; i++)
            {
                end += text + "\n";
            }
            System.Windows.Forms.MessageBox.Show(end);
            return 0;
        }
        private void Output_Click(object sender, EventArgs e)
        {
            int len = BlaBla(this.Input.Text, (int)this.Times.Value);
            System.Windows.Forms.MessageBox.Show("D³ugoœæ wiadomoœci to: " + (this.Input.TextLength * this.Times.Value).ToString());
        }
    }
}