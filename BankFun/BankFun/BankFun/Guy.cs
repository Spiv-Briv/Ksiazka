using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFun
{
    internal class Guy
    {
        private string Name { get; }
        private int Cash { get; set; }
        public Guy(string name, int cash)
        {
            Name = name;
            Cash = cash;
        }
        public string Deposit(int am)
        {
            this.Cash -= am;
            return UpdateLabel();
        }
        public string Withdraw(int am)
        {
            this.Cash += am;
            return UpdateLabel();
        }
        private string UpdateLabel()
        {
            return this.Name + " ma " + this.Cash + "zł";
        }
        public string getName()
        {
            return this.Name;
        }
        public int GetCash()
        {
            return this.Cash;
        }
    }
}
