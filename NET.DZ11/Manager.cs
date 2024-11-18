using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class Manager:Worker
    {
        public Manager() { }
        public Manager(string name, int age, int employmenthistory)
        {
            Name = name;
            Age = age;
            Employmenthistory = employmenthistory;
        }

        public override void Print5()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Manager Name ->" + Name);
            Console.WriteLine("Manager Age ->" + Age);
            Console.WriteLine("Manager Employmenthistory ->" + Employmenthistory);
        }
    }
}
