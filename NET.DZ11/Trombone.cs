using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class Trombone : MusicalInstrument
    {
        new public string Name = "Trombone";
        new public string Сharacteristics = "A brass wind musical instrument, the distinctive feature of which is the presence of a movable slide, smoothly changing the volume of air in the instrument and, accordingly, the pitch of its sound.";
        public override void Sound()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Uf,uf,u,ufsa,ug,");
        }
        public override void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(Name);
        }
        public override void Desc()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(Сharacteristics);
        }
        public override void History()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("The appearance of the trombone dates back to the 15th century. It is generally accepted that the immediate predecessors of this instrument were slide trumpets, when playing which the musician had the ability to move the instrument's tube, thus obtaining a chromatic scale. Such trumpets were used to double the voices of a church choir, given the similarity of the timbre of the trumpet to the human voice. It was only necessary to achieve similarity of intonation, for which purpose a slide was made, giving chromaticism and vibrato");
        }
    }
}
