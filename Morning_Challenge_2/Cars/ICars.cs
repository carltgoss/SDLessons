using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Morning_Challenge_2.Cars
{
    public interface ICars
    {
        string Make { get; }
        string Model { get; }
        string Color { get; }
        bool isRunning { get; }
        void Start();
        void TurnOff();
        void Drive();
    }
}
