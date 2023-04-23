using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDoor
{
    public class Bark
    {
        public string Sound { get; private set; }

        public Bark(string sound)
        {
            Sound = sound;
        }

        public override bool Equals(object? bark)
        {
            if (bark != null && bark.GetType() == this.GetType())
            {
                Bark otherBark = (Bark)bark;
                if(string.Equals(this.Sound, otherBark.Sound, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
