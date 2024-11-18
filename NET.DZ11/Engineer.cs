using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class Engineer : Worker
    {
        public Engineer() { }
        public Engineer(string name, int age, int employmenthistory)
        {
            Name = name;
            Age = age;
            Employmenthistory = employmenthistory;
        }

        public override void Print5()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Engineer Name ->" + Name);
            Console.WriteLine("Engineer Age ->" + Age);
            Console.WriteLine("Engineer Employmenthistory ->" + Employmenthistory);
        }
    }
}

