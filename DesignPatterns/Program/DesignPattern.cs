﻿using DesignPatterns.Program.factorys;
using DesignPatterns.Program.factorys.interfaces;
using DesignPatterns.Program.interfaces;

namespace DesignPatterns.Program
{
    public class DesignPattern : IPattern, ICreational, IStructural
    {
        private static Dictionary<string,IFactory> _patterns = new Dictionary<string, IFactory>();

        private DesignPattern() {

            _patterns.Add("Creational", new CreationalPatternFactory());
            _patterns.Add("Structural", new StructuralPatternFactory());
        }

        public static IPattern ChoosePattern()
        {
            return new DesignPattern();
        }
        public ICreational CreationalPatterns()
        {
            return this;
        }

        public string Builder()
        {
            return _patterns["Creational"].Show(Constants.BUILDER);
        }

        public string Prototype()
        {
            return _patterns["Creational"].Show(Constants.PROTOTYPE);
        }

        public string AbstractFactory()
        {
            return _patterns["Creational"].Show(Constants.ABSTRACT_FACTORY);
        }

        public string Singleton()
        {
            return _patterns["Creational"].Show(Constants.SINGLETON);
        }

        public string SimpleFactory()
        {
            return _patterns["Creational"].Show(Constants.SIMPLE_FACTORY);
        }

        public IStructural StructuralPatterns()
        {
            return this;
        }

        public string Composite()
        {
            return _patterns["Structural"].Show(Constants.COMPOSITE);
        }

        public string Decorator()
        {
            return _patterns["Structural"].Show(Constants.DECORATOR);
        }

        public string Facade()
        {
            return _patterns["Structural"].Show(Constants.FACADE);
        }

        public string Flyweight()
        {
            return _patterns["Structural"].Show(Constants.FLYWEIGHT);
        }

        public string Proxy()
        {
            return _patterns["Structural"].Show(Constants.PROXY);
        }

        public string Adapter()
        {
            return _patterns["Structural"].Show(Constants.ADAPTER);
        }

        public string Bridge()
        {
            return _patterns["Structural"].Show(Constants.BRIGDE);
        }
    }
}
