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
        private Dictionary<string, string> Properties { get; set; }
        public InstrumentSpec(Dictionary<string, string> properties)
        {
            if(properties == null)
            {
                Properties = new Dictionary<string, string>();
            }
            else
            {
                Properties = new Dictionary<string, string>(properties);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var prop in Properties)
            {
                sb.Append($"{prop.Key}: {prop.Value}\n");
            }
            return sb.ToString();
        }

        public virtual bool matches(InstrumentSpec instrumentSpec)
        {
            foreach (var property in instrumentSpec.Properties)
            {
                if(!Properties.TryGetValue(property.Key, out var propValue) || !propValue.Equals(property.Value))
                {
                    return true;
                }
            }
            return true;
        }
    }
}
