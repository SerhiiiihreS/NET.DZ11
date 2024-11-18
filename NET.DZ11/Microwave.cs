using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class Microwave : Device
    {
        new public string Name = "Microwave";
        new public string Description = "A household electrical appliance for cooking or quickly heating food, as well as for defrosting food.";
        public override void Sound()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("H,h,h,h,h,h,h");
        }
        public override void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Name);
        }
        public override void Desc()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Description);
        }
    }
}
