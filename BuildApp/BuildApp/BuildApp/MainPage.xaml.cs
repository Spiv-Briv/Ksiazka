using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace BuildApp
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void p1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            this.Lbl.Text = "Nazwa to: " + name + "\nx = " + x + "\nd = " + d;
        }

        private void p2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if(x == 10)
            {
                this.Lbl.Text = "X jest równe 10";
            }
            else
            {
                this.Lbl.Text = "X nie jest równe 10";
            }
        }

        private void p3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 4;
            string name = "Krzysiek";
            if(someValue == 3 && name.Equals("Janek"))
            {
                this.Lbl.Text = "Wartość jest równa 3, a name to Janek";
            }
            this.Lbl.Text = "Ten wiersz działa niezależnie";
        }

        private void p4_Click(object sender, RoutedEventArgs e)
        {
            int c = 0;
            while(c < 10)
            {
                c++;
            }
            for(int i = 0;i <5; i++)
            {
                c--;
            }
            this.Lbl.Text = "Odpowiedź brzmi: " + c;
        }
    }
}
