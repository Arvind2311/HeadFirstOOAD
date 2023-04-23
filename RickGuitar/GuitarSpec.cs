using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rick.guitar
{
    public class GuitarSpec
    {
        public Builder Builder { get; set; }
        public string Model { get; set; }
        public Type Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }
        public int NumStrings { get; set; }
        public GuitarSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood, int numStrings)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
            NumStrings = numStrings;
        }

        public override string? ToString()
        {
            return $"Builder: {this.Builder}, Model: {this.Model}, Type: {this.Type}," +
                $" Backwood: {this.BackWood}, TopWood: {this.TopWood}, Strings: {this.NumStrings}";
        }

        public bool matches(GuitarSpec guitarSpec)
        {
            if (guitarSpec.Builder != this.Builder)
            {
                return false;
            }
            if (guitarSpec.Model.ToLower() != this.Model.ToLower())
            {
                return false;
            }
            if (guitarSpec.Type != this.Type)
            {
                return false;
            }
            if (guitarSpec.BackWood != this.BackWood)
            {
                return false;
            }
            if (guitarSpec.TopWood != this.TopWood)
            {
                return false;
            }
            if (guitarSpec.NumStrings != this.NumStrings)
            {
                return false;
            }
            return true;
        }
    }
}
