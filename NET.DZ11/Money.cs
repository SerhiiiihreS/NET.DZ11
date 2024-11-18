using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class Money
    {
        protected double Banknote {get;set;}
        protected double Coin { get;set;}  
        
        public Money() { }
        public void Setprice(double banknote, double coin)
        {
            Banknote = banknote;
            Coin = coin;
        }

        public virtual void Print()
        { 
            Console.WriteLine(Banknote + "," + Coin);
        }
    }
}
 