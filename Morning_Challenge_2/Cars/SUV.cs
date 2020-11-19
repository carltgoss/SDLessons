using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning_Challenge_2.Cars
{
    public class SUV : ICars
    {
        // this is a field not a property
        // private fields usually use underscores
        private bool _isRunning = false;

        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public void Start()
        {
            if (_isRunning)
            {
                Console.WriteLine("Awful Noise");
            }
            else
            {
                _isRunning = true;
                Console.WriteLine("The SUV starts up");
            }
        }
        public void TurnOff()
        {

        }

    }
    public class Trailblazer : SUV
    {
        public string Make
        {
            get { return "Chevrolet"; }
        }
    }
}
