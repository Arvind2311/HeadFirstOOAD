using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDoor
{
    public class DogDoor
    {
        public bool Open { get; private set; }
        private Timer timer;
        private List<Bark> allowedBarks = new List<Bark>();

        public DogDoor() 
        { 
            this.Open = false;
        }

        public void open()
        {
            Console.WriteLine("The dog door opens.");
            Open = true;

            timer = new Timer(timerEvent, null, 5000, Timeout.Infinite);
        }

        private void timerEvent(Object sender)
        {
            close();
            timer.Dispose();
        }

        public void close()
        {
            Console.WriteLine("The dog door closes.");
            Open = false;
        }

        public bool isOpen()
        {
            return Open;
        }

        public void SetAllowedBarks(Bark bark)
        {
            allowedBarks.Add(bark);
        }

        public List<Bark> GetAllowedBarks()
        {
            return allowedBarks;
        }
    }
}
