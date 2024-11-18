using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class President:Worker
    {
        public President() { }
        public President(string name, int age, int employmenthistory) 
        {
            Name = name;
            Age = age;
            Employmenthistory=employmenthistory;
        }

        public override void Print5() 
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("President Name ->"+Name);
            Console.WriteLine("President Age ->" + Age);
            Console.WriteLine("President Employmenthistory ->" + Employmenthistory);
        }
    }
}
