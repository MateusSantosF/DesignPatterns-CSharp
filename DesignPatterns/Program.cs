using DesignPatterns.Behavioural.Iterator.interfaces;
using DesignPatterns.Behavioural.Iterator.model;
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


            NumbersCollection collection = new NumbersCollection(5, false);

            collection.AddInt(1);
            collection.AddInt(2);
            collection.AddInt(3);
            collection.AddInt(4);
            collection.AddInt(5);

            MyIterator iterator = collection.GetIterator();

            collection.MyFor(iterator);
        }
    }
}


