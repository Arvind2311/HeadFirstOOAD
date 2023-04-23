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
            if(spec is GuitarSpec) 
            {
                instrument = new Guitar(serialNumber, price, (GuitarSpec) spec);
            }
            else if (spec is MandolinSpec)
            {
                instrument = new Mandolin (serialNumber, price, (MandolinSpec) spec);
            }
            instruments.Add(instrument);
        }


        public List<Instrument> search(GuitarSpec guitarSpec)
        {
            List<Instrument> result = new List<Instrument>();
            foreach (var instrument in instruments)
            {
                if (instrument is Guitar && instrument.Spec.matches(guitarSpec))
                {
                    result.Add(instrument);
                }
            }
            return result;
        }

        public List<Instrument> search(MandolinSpec mandolinSpec)
        {
            List<Instrument> result = instruments.Where(i => i is Mandolin && ((Mandolin)i).Spec.matches(mandolinSpec)).ToList();
            return result;
        }
    }
}
