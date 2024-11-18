using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product a= new Product("inucdv");
            a.Setprice(5, 25);
            a.Print();
            a.Reduceprice(1, 05);
            Console.WriteLine();


            Kettle h = new Kettle();
            h.Show();
            h.Desc();
            h.Sound();
            Console.WriteLine();
            Microwave h1 = new Microwave();
            h1.Show();
            h1.Desc();
            h1.Sound();
            Console.WriteLine();
            Car h2 = new Car();
            h2.Show();
            h2.Desc();
            h2.Sound();
            Console.WriteLine();
            Steamboat h3 = new Steamboat();
            h3.Show();
            h3.Desc();
            h3.Sound();
            Console.WriteLine();


            Violin h4 = new Violin();
            h4.Show();
            h4.Desc();
            h4.Sound();
            h4.History();
            Console.WriteLine();
            Trombone h5 = new Trombone();
            h5.Show();
            h5.Desc();
            h5.Sound();
            h5.History();
            Console.WriteLine();
            Ukulele h6 = new Ukulele();
            h6.Show();
            h6.Desc();
            h6.Sound();
            h6.History();
            Console.WriteLine();
            Cello h7 = new Cello();
            h7.Show();
            h7.Desc();
            h7.Sound();
            h7.History();
            Console.WriteLine();

            President h8 = new President("Tramp",68,4);
            h8.Print5();
            Security h9 = new Security("Gtegcju",34,12);
            h9.Print5();
            Manager h10 = new Manager("Bill", 20, 5);
            h10.Print5();
            Engineer h11 = new Engineer("Tom", 46, 34);
            h11.Print5();

        }
    }
}
