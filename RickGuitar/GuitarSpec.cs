using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickGuitar
{
    public class GuitarSpec : InstrumentSpec
    {
        public int NumStrings { get; set; }
        public GuitarSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood, int numStrings) : base(builder, model, type, backWood, topWood)
        {
            NumStrings = numStrings;
        }

        public override string? ToString()
        {
            return $"Builder: {this.Builder}, Model: {this.Model}, Type: {this.Type}," +
                $" Backwood: {this.BackWood}, TopWood: {this.TopWood}, Strings: {this.NumStrings}";
        }

        public bool matches(GuitarSpec guitarSpec)
        {
            if (guitarSpec.NumStrings != this.NumStrings)
            {
                return false;
            }
            return true;
        }
    }
}
