using DesignPatterns.Creational.AbstractFactory.interfaces;


namespace DesignPatterns.Creational.AbstractFactory.models
{
    internal class ModernTable : ITable
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
            return "I'm Modern";
        }
    }
}
