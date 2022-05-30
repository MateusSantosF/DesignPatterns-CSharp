using DesignPatterns.Creational.AbstractFactory.interfaces;
using DesignPatterns.Creational.AbstractFactory.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
   
    internal class ModernAbstractFactory : IAbstractFactory
    {
        /// <summary>
        /// Use o Abstract Factory quando seu código precisa trabalhar com diversas famílias de produtos relacionados,
        /// mas que você não quer depender de classes concretas daqueles produtos-eles podem ser desconhecidos de antemão 
        /// ou você simplesmente quer permitir uma futura escalabilidade.
        /// </summary>
        public ModernAbstractFactory()
        {
        
        }
        public IChair createChair()
        {
            return new ModernChair();
        }

        public ISofa createSofa()
        {
            return new ModernSofa();
        }

        public ITable createTable()
        {
            return new ModernTable();
        }
    }
}
