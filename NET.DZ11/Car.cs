using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class Car : Device
    {
        new public string Name = "Car";
        new public string Description = "A self-propelled vehicle with an engine for transporting goods and passengers on trackless tracks.";
        public override void Sound()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ju,jujuju");
        }
        public override void Show()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(Name);
        }
        public override void Desc()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(Description);
        }
    }
}
