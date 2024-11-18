using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class MusicalInstrument
    {
        public string Name { get; set; }
        public string Сharacteristics { get; set; }
        public MusicalInstrument() { }
        public MusicalInstrument(string name, string сharacteristics)
        {
            Name = name;
            Сharacteristics = сharacteristics;
        }
        public virtual void Sound() { }
        public virtual void Show() { }
        public virtual void Desc() { }
        public virtual void History() { }
    }
}
