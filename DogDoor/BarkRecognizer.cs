using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDoor
{
    public class BarkRecognizer
    {
        private DogDoor door;

        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }

        public void recognize(Bark bark)
        {
            Console.WriteLine($"Bark recognizer heard a '{bark.Sound}'");
            if(door.GetAllowedBarks().Any(allowedBark => allowedBark.Equals(bark)))
            {
                door.open();
            }
            else
            {
                Console.WriteLine("This dog is not allowed");
            }
        }
    }
}
