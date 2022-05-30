
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.models
{
    internal class SportCar 
    {

        public int Engine { get; set; }
        public int Seats { get; set; }

        public SportCar() { }

        public SportCar(int engine, int seats) 
        {
            Engine = engine;
            Seats = seats;
        }
    }
}
