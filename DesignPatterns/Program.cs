using DesignPatterns.Behavioural.Strategy;
using DesignPatterns.Behavioural.Strategy.model;
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
          Behavioral Patterns
             - [x] Observer
             - [x] Memento
             - [x] Command
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
                                          .Strategy();
            Console.WriteLine(pattern);


        }
    }
}


