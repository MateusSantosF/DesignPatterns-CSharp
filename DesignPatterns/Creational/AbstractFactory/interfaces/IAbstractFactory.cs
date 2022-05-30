using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.interfaces
{
    internal interface IAbstractFactory
    {

        IChair createChair();
        ITable createTable();
        ISofa createSofa();

    }
}
