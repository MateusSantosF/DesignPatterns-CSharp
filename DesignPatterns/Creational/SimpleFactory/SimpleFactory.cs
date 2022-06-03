
using DesignPatterns.Creational.SimpleFactory.model;

namespace DesignPatterns.Creational.SimpleFactory
{
    public class SimpleFactory
    {

        public static Pizza? Make(string taste)
        {
            switch (taste)
            {
                case "Margherita":
                    return new PizzaMargherita();
                case "Pepperoni":
                    return new PizzaPepperoni();
                default:
                    return null;
            }

        }
    }
}
