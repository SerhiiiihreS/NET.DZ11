using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class Steamboat : Device
    {
        new public string Name = "Steamboat";
        new public string Description = " A vessel equipped with a piston steam engine or a steam turbine as a traction engine.";
        public override void Sound()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("U,u,u,u,u,");
        }
        public override void Show()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Name);
        }
        public override void Desc()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Description);
        }
    }
}
