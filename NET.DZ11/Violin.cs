using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class Violin: MusicalInstrument
    {
        new public string Name = "Violin";
        new public string Сharacteristics = " A bowed string musical instrument with four strings tuned in fifths: Gm D1 A1 E2. The highest register variety of the violin family, below which are the viola, cello and double bass.";
        public override void Sound()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Uf,u,uf,u,ug,");
        }
        public override void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Name);
        }
        public override void Desc()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Сharacteristics);
        }
        public override void History()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("The violin is the result of further development of such instruments as the fiddle (viela), lira da braccio and rebec[2][3]. Research in the 1970s showed a historical connection between the violin and the folk stringed musical instruments of the Slavs, including the southern and western ones.");
        }
    }
}

