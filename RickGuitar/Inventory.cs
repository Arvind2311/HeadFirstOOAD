using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace rick.guitar
{
    public class Inventory
    {
        public List<Guitar> guitars;
        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void addGuitar(string serialNumber, double price, Builder builder, string model, Type type, Wood backWood, Wood topWood, int numStrings)
        {
            Guitar guitar = new Guitar(serialNumber, price, new GuitarSpec(builder, model, type, backWood, topWood, numStrings));
            guitars.Add(guitar);
        }


        public List<Guitar> search(GuitarSpec guitarSpec)
        {
            List<Guitar> result = new List<Guitar>();
            foreach (var guitar in guitars)
            {
                if (guitar.GuitarSpec.matches(guitarSpec))
                {
                    result.Add(guitar);
                }
            }
            return result;
        }
    }
}
