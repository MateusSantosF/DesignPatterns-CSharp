

using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory.interfaces;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Composite.model;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Decorator.model;
using DesignPatterns.Structural.Facade;

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

            var encrypt = true;
            var compress = true;
            var source = new DataSourceDecorator(new FileDataSource());

            if (encrypt)
            {
                source = new EncryptionDecorator(source);
            }
            if (compress)
            {
                source = new CompressionDecorator(source);
            }

            source.WriteData("Anything");
            Console.WriteLine(source.ReadData());

           

        }
    }
}


