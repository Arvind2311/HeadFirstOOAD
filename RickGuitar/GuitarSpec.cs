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

        public override bool matches(InstrumentSpec otherSpec)
        {
            if (!base.matches(otherSpec))
            {
                return false;
            }
            if (!(otherSpec is GuitarSpec))
            {
                return false;
            }
            GuitarSpec spec = (GuitarSpec)otherSpec;
            if (!NumStrings.Equals(spec.NumStrings))
            {
                return false;
            }
            return true;
        }
    }
}
