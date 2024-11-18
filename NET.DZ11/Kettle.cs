using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class Kettle:Device
    {
        new public string Name = "Kettle";
        new public string Description = "A vessel with a handle and a spout for boiling water or brewing tea.";
        public override void Sound()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Tu,tu,tu");
        }
        public override void Show()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(Name);
        }
        public override void Desc()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(Description);
        }
    }
}
