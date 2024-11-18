using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    internal class Device
    {
        public string Name {  get; set; }
        public string Description { get; set; }
        public Device() { }
        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public virtual void Sound() { }
        public virtual void Show() { }
        public virtual void Desc() { }
    }
}
