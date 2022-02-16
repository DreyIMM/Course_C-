using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDiamente.Devices
{
    abstract class Device
    {
        public int serialNumber { get; set; }

        public abstract void ProcessDoc(string document);


    }
}
