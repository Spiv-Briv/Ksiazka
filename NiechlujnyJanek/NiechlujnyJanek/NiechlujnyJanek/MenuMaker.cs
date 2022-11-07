using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiechlujnyJanek
{
    internal class MenuMaker
    {
        public Random Randomizer = new Random();
        private string[] Mieso = { "Pieczona wołowina", "Salami", "Indyk", "Szynka", "Karkówka" };
        private string[] Sosy = { "żółta musztarda", "brązowa musztarda", "musztarda miodowa", "majonez", "przyprawa", "sos francuski" };
        private string[] Pieczywo = { "chleb ryżowy", "chleb biały", "chleb zbożowy", "pumpernikiel", "chleb włoski", " bułka" };
        public string GetMenuItem()
        {
            return Mieso[Randomizer.Next(Mieso.Length)] + ", " + Sosy[Randomizer.Next(Sosy.Length)] + ", " + Pieczywo[Randomizer.Next(Pieczywo.Length)];
        }
    }
}
