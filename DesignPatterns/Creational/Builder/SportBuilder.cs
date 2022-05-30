using DesignPatterns.Creational.Builder.interfaces;
using DesignPatterns.Creational.Builder.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    internal class SportBuilder : IBuilder
    {
        private SportCar result;
        int engine;
        int seats;

        public void setEngine(int engine)
        {
            this.engine = engine;
        }

        public void setSeats(int seats)
        {
            this.seats = seats;
        }

        public SportCar getResult()
        {
            this.result = new SportCar() { Engine = engine, Seats = seats };
            return result;
        }
    }
}
