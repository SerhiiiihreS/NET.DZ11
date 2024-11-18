using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class Ukulele : MusicalInstrument
    {
        new public string Name = "Ukulele";
        new public string Сharacteristics = "A four-string type of guitar used for chord accompaniment of songs and solo playing[1].";
        public override void Sound()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("U,u,u,u,u,");
        }
        public override void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(Name);
        }
        public override void Desc()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(Сharacteristics);
        }
        public override void History()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The ukulele appeared in Hawaii in the second half of the 19th century, where it was brought by the Portuguese from the island of Madeira under the name machete da braça[1]. The first ukulele shop in Hawaii was opened in 1880 by Manuel Nunes (1843−1922[2])[3]. Hawaiians use the ukulele to perform sentimental songs in English and \"Hawaiian-style\" music[4]");
        }
    }
}
