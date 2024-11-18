using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class Security : Worker
    {
        public Security() { }
        public Security(string name, int age, int employmenthistory)
        {
            Name = name;
            Age = age;
            Employmenthistory = employmenthistory;
        }

        public override void Print5()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Security Name ->" + Name);
            Console.WriteLine("Security Age ->" + Age);
            Console.WriteLine("Security Employmenthistory ->" + Employmenthistory);
        }
    }
}
