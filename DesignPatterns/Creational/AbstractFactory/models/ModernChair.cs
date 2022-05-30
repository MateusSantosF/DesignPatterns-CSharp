using DesignPatterns.Creational.AbstractFactory.interfaces;


namespace DesignPatterns.Creational.AbstractFactory.models
{
    internal class ModernChair : IChair
    {
        public bool hasLegs()
        {
            return true;
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
