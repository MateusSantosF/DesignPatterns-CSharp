
using DesignPatterns.Behavioural.CommandPattern;
using DesignPatterns.Behavioural.CommandPattern.model;
using DesignPatterns.Behavioural.Memento;
using DesignPatterns.Behavioural.Observer.model;
using DesignPatterns.Program;

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
            string pattern = DesignPattern.ChoosePattern()
                                          .BehavioralPatterns() 
                                          .Memento(); 
            Console.WriteLine(pattern);

        }
    }
}


