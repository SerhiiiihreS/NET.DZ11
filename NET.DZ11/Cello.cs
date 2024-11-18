using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class Cello : MusicalInstrument
    {
        new public string Name = "Cello";
        new public string Сharacteristics = "A small double bass[3]\", derived from viola[3][4]) is a bowed musical instrument with 4 strings tuned in fifths: Cб Gб Dм Aм. In terms of pitch, it occupies an intermediate position between the higher viola and the low double bass.";
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
            Console.WriteLine(Сharacteristics);
        }
        public override void History()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The cello appeared in the early 16th century. Initially, it was used as a bass instrument to accompany singing (or to play on an instrument of a higher register). There were numerous varieties of cello, differing from each other in size, number of strings, tuning (most often, a tuning one tone lower than the modern one was encountered).");
        }
    }
}
