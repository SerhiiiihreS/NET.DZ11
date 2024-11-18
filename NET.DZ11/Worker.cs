using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ11
{
    abstract class Worker
    {
        protected string Name {  get; set; }
        protected int Age { get; set; }
        protected int Employmenthistory { get; set; }
        protected Worker() { }
        public abstract void Print5();
       
    }
}
