using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class Product:Money
    {
        public string Name {  get; set; }   
        public Product() { }
        public Product(string name)
        {
            Name = name;
        }
        public override void Print()
        {
            Console.WriteLine("Name ->"+Name);
            Console.WriteLine("Price ->"+Banknote + "," + Coin);
        }
        public void Reduceprice(double bm,double cm)
        {
            Console.WriteLine("Name ->" + Name);
            Console.WriteLine("Price ->" + (Banknote-bm) + "," + (Coin-cm));
        }
    }
}
