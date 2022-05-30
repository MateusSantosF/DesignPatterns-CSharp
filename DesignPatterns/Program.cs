

using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory.interfaces;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;

namespace Program
{

    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("======== Singleton =======");
            var singleton = Singleton.getInstance();
            singleton.bussinesLogic();
            Console.WriteLine("========END OF Singleton =======");

            Console.WriteLine("\n======== PROTOTYPE =======");
            var prop = new Prototype() { Age = 20, Name = "Mateus", children = new ChildrenPrototype() { Id = 2 } };
            Console.WriteLine(prop.children.Id);
            Console.WriteLine("===============");
            var copy = (Prototype) prop.ShallowClone();
            copy.Name = "Joao";
            Console.WriteLine(prop.Name);
            Console.WriteLine(copy.Name);
            Console.WriteLine("===============");
            var anotherCopy = (Prototype) prop.DeepClone();
            anotherCopy.children.Id = 20;

            Console.WriteLine(prop.children.Id);
            Console.WriteLine(anotherCopy.children.Id);

            Console.WriteLine("========         FACTORY        =======");

            var optionFactory = 1;
            IAbstractFactory factory = null;

            if (optionFactory == 0)
            {
                factory = new ModernAbstractFactory();
            }
            else
            {
                factory = new VintageAbstractFactory();
            }

            var chair = factory.createChair();
            var table = factory.createTable();
            var sofa = factory.createSofa();

            Console.WriteLine(chair.ToString() + " Chair");
            Console.WriteLine(table.ToString() + " Table");
            Console.WriteLine(sofa.ToString() + " Sofa");


        }
    }
}


