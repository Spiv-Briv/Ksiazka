using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slonie
{
    internal class Elephant
    {
        private string Name { get; }
        private int EarSize { get; }
        public Elephant(string name, int earSize)
        {
            Name = name;
            EarSize = earSize;
        }
        public void WhoAmI()
        {
            MessageBox.Show("Moje uszy mają " + EarSize + " centymetrów", Name + " mówi...");
        }
        public Button Display()
        {
            Button przycisk = new Button();
            przycisk.Name = Name;
            przycisk.Text = Name;
            return przycisk;
        }
    }
}
