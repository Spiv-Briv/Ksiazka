namespace Literki
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if(listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                timer1.Stop();
                MessageBox.Show("Koniec gry!\nKoñcowy poziom trudnoœci to: " + (800 - timer1.Interval));
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if(timer1.Interval > 400)
                {
                    timer1.Interval -= 10;
                }
                if (timer1.Interval > 250)
                {
                    timer1.Interval -= 7;
                }
                if(timer1.Interval > 100)
                {
                    timer1.Interval -= 2;
                }
                DifficultyBar.Value = 800 - timer1.Interval;
                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }
            correctLabel.Text = "Prawid³owych: " + stats.Correct;
            missedLabel.Text = "B³êdów: " + stats.Missed;
            allLabel.Text = "Wszystkich: " + stats.Total;
            AccuracyLabel.Text = "Dok³adnoœæ: " + stats.Accuracy + "%";
        }
    }
}