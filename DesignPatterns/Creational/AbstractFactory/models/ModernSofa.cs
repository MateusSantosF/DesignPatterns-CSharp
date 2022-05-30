using DesignPatterns.Creational.AbstractFactory.interfaces;



namespace DesignPatterns.Creational.AbstractFactory.models
{
    internal class ModernSofa : ISofa
    {
        public bool hasLegs()
        {
            return false;
        }

        public bool sitOn()
        {
            return true;
        }

        public override string ToString()
        {
            return "I'm Modern";
        }
    }
}
