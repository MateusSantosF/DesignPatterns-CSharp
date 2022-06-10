using DesignPatterns.Program;
using DesignPatterns.Structural.Bridge.model;

namespace Program
{
    public class Program
    {
        /*Explore design patterns using Builder below!
         
          Creational Patterns
             - [x] SimpleFactory
             - [x]Abstract Factory
             - [x] Singleton
             - [x] Prototype
             - [x] Builder
         Structural Patterns
             - [x] Facade
             - [x] Decorator
             - [x] Composite
             - [x] Flyweight
             - [x] Proxy
             - [x] Bridge
             - [x] Adapter         
        */
        public static void Main(string[] args)
        {
            string pattern = DesignPattern.ChoosePattern().StructuralPatterns().Bridge();
            Console.WriteLine(pattern);
        }
    }
}


