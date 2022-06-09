using DesignPatterns.Creational.Builder.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    internal class Director
    {
        public Director() { }
        public void makeManualCar(IBuilder builder)
        {
            builder.setSeats(4);
            builder.setEngine(1);
           
        }

        public void makeSportCar(IBuilder builder)
        {
            builder.setSeats(5);
            builder.setEngine(3);
        }

    }
}
