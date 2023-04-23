using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace RickGuitar
{
    public class Inventory
    {
        public List<Instrument> instruments;
        public Inventory()
        {
            instruments= new List<Instrument>();
        }

        public void addInstrument(string serialNumber, double price, InstrumentSpec spec)
        {
            Instrument instrument = null;
            if(instrument is Guitar) 
            {
                Guitar guitar = new Guitar(serialNumber, price, (GuitarSpec) spec);
            }
            else if (instrument is Mandolin) 
            {
                Mandolin mandolin = new Mandolin (serialNumber, price, (MandolinSpec) spec);
            }
        }


        public List<Instrument> search(GuitarSpec guitarSpec)
        {
            List<Instrument> result = new List<Instrument>();
            foreach (var instrument in instruments)
            {
                if (instrument.Spec.matches(guitarSpec))
                {
                    result.Add(instrument);
                }
            }
            return result;
        }

        public List<Instrument> search(MandolinSpec mandolinSpec)
        {
            List<Instrument> result = new List<Instrument>();
            foreach (var instrument in instruments)
            {
                if (instrument.Spec.matches(mandolinSpec))
                {
                    result.Add(instrument);
                }
            }
            return result;
        }
    }
}
