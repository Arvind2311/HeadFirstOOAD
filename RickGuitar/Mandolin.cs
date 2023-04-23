using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickGuitar
{
    public class Mandolin : Instrument
    {
        public Mandolin(string serialNumber, double price, MandolinSpec mandolinSpec) : base(serialNumber, price, mandolinSpec)
        {
        }
    }
}
