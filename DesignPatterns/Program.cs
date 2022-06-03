

using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory.interfaces;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Composite.model;
using DesignPatterns.Structural.Composite;

namespace Program
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("======== Singleton =======");
            var singleton = Singleton.getInstance();
            singleton.bussinesLogic();
   
            Console.WriteLine("\n======== PROTOTYPE =======");
            var prop = new Prototype() { Age = 20, Name = "Mateus", children = new ChildrenPrototype() { Id = 2 } };
            Console.WriteLine("Initial ID = " + prop.children.Id);
   
            var copy = (Prototype) prop.ShallowClone();
            copy.Name = "Joao";
            Console.WriteLine("Original name =" +prop.Name);
            Console.WriteLine("Shallow Copy Name =" + copy.Name);

            var anotherCopy = (Prototype) prop.DeepClone();
            anotherCopy.children.Id = 20;

            Console.WriteLine("Original Id =" + prop.children.Id);
            Console.WriteLine("Deep Copy ID =" + anotherCopy.children.Id);

            Console.WriteLine("\n========         FACTORY        =======");

            var optionFactory = 1;
            IAbstractFactory? factory = null;

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

            Console.WriteLine("\n========         BUILDER        =======");

            Director director = new Director();

            SportBuilder builder = new SportBuilder();
            director.makeSportCar(builder);

            var car = builder.getResult();

            Console.WriteLine("Car built = " + car.GetType());

            Console.WriteLine("\n========         FACADE        =======");
            VideoConverterFacade converter = new VideoConverterFacade();
            string mp4Video = converter.Convert("youtubevideo.ogg", "mp4");

            Console.WriteLine("\n========         DECORATOR        =======");
            var source = new FileDataSource();

            source.WriteData("Some thing");
            Console.WriteLine(source.ReadData());

            Console.WriteLine("Using decorator...");
            var source2 = new EncryptionDecorator(source);
            source2.WriteData("Some thing");
            Console.WriteLine(source2.ReadData());

            Console.WriteLine("Using decorator 2...");
            var source3 = new EncryptionDecorator(source2);
            source3.WriteData("Some thing");
            Console.WriteLine(source3.ReadData());

        }
    }
}


