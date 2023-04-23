using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RickGuitar;

namespace RickGuitar
{
    public class InstrumentSpec
    {
        public Builder Builder { get; set; }
        public string Model { get; set; }
        public Type Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }
        public InstrumentSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }
        public virtual bool matches(InstrumentSpec instrumentSpec)
        {
            if (instrumentSpec.Builder != this.Builder)
            {
                return false;
            }
            if (instrumentSpec.Model.ToLower() != this.Model.ToLower())
            {
                return false;
            }
            if (instrumentSpec.Type != this.Type)
            {
                return false;
            }
            if (instrumentSpec.BackWood != this.BackWood)
            {
                return false;
            }
            if (instrumentSpec.TopWood != this.TopWood)
            {
                return false;
            }
            return true;
        }
    }
}
