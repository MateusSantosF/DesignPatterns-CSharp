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
                                          .StructuralPatterns() 
                                          .Bridge(); 
            Console.WriteLine(pattern);


            Subject subject = new Subject();

            ConcreteObserverA observerA = new ConcreteObserverA("Observer A");
            ConcreteObserverA observerA2 = new ConcreteObserverA("Observer A2");

            ConcreteObserverB observerB = new ConcreteObserverB("Observer B");

            subject.Attach(observerA);
            subject.Attach(observerA2);
            subject.Attach(observerB);

            subject.ChangeState(2);
            subject.ChangeState(4);
        }
    }
}


