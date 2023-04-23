using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickGuitar
{
    public class MandolinSpec : InstrumentSpec
    {
        public Style Style { get; set; }
        public MandolinSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood, Style style) : base(builder, model, type, backWood, topWood)
        {
            Style = style;
        }

        public override string? ToString()
        {
            return $"Builder: {this.Builder}, Model: {this.Model}, Type: {this.Type}," +
                $" Backwood: {this.BackWood}, TopWood: {this.TopWood}, Style: {this.Style}";
        }

        public override bool matches(InstrumentSpec otherSpec)
        {
            if (!base.matches(otherSpec))
            {
                return false;
            }
            if(!(otherSpec is MandolinSpec))
            {
                return false;
            }
            MandolinSpec spec = (MandolinSpec)otherSpec;
            if(!Style.Equals(spec.Style))
            {
                return false;
            }
            return true;
        }
    }
}
