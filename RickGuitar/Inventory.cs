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
            Instrument instrument = new Instrument(serialNumber, price, spec);
            instruments.Add(instrument);
        }

        public List<Instrument> search(InstrumentSpec instrumentSpec)
        {
            List<Instrument> result = instruments.Where(i => i.Spec.matches(instrumentSpec)).ToList();
            return result;
        }
    }
}
