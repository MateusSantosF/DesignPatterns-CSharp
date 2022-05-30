using DesignPatterns.Creational.AbstractFactory.interfaces;
using DesignPatterns.Creational.AbstractFactory.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{

    internal class VintageAbstractFactory : IAbstractFactory
    {
        /// <summary>
        /// Use o Abstract Factory quando seu código precisa trabalhar com diversas famílias de produtos relacionados,
        /// mas que você não quer depender de classes concretas daqueles produtos-eles podem ser desconhecidos de
        /// antemão ou você simplesmente quer permitir uma futura escalabilidade.
        /// </summary>
        public VintageAbstractFactory()
        {

        }
        public IChair createChair()
        {
            return new VintageChair();
        }

        public ISofa createSofa()
        {
            return new VintageSofa();
        }

        public ITable createTable()
        {
            return new VintageTable();
        }
    }
}
