using DesignPatterns.Behavioural.Iterator.interfaces;
using DesignPatterns.Behavioural.Iterator.model;
using DesignPatterns.Behavioural.Mediator;
using DesignPatterns.Behavioural.Mediator.model;
using DesignPatterns.Behavioural.Visitor;
using DesignPatterns.Behavioural.Visitor.model;
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
             - [x] Strategy
             - [x] Iterator
             - [x] Visitor
             - [x] Mediator
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
                                          .Visitor();
            Console.WriteLine(pattern);

          

     


        }
    }
}


