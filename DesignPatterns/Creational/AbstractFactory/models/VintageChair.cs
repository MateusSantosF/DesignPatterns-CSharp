using DesignPatterns.Creational.AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.models
{
    internal class VintageChair : IChair
    {
        public bool hasLegs()
        {
            return true;
        }

        public bool sitOn()
        {
            return false;
        }

        public override string ToString()
        {
            return "I'm vintage";
        }
    }
}
