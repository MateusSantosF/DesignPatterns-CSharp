
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.models
{
    internal class ManualCar 
    {
        public int Engine { get; set; }
        public int Seats { get; set; }

        public ManualCar()
        {
        }

        public ManualCar(int engine, int seats)
        {
            this.Engine = engine;
            this.Seats = seats;
        }
   
    }
}
