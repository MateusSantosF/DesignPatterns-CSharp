
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
                                          .StructuralPatterns() 
                                          .Bridge(); 
            Console.WriteLine(pattern);


            //Subject subject = new Subject();

            //ConcreteObserverA observerA = new ConcreteObserverA("Observer A");
            //ConcreteObserverA observerA2 = new ConcreteObserverA("Observer A2");

            //ConcreteObserverB observerB = new ConcreteObserverB("Observer B");

            //subject.Attach(observerA);
            //subject.Attach(observerA2);
            //subject.Attach(observerB);

            //subject.ChangeState(2);
            //subject.ChangeState(4);


            //Editor editor = new Editor();
            //Button copyButton = new Button(new CopyCommand( editor));
            //Button pasteButton = new Button(new PasteCommand( editor));

            //editor.CurrentText = "Hello";
            //editor.SelectedText = "World!";


            //copyButton.Click();
            //pasteButton.Click();
            //Console.WriteLine(editor.CurrentText);
            //editor.UndoChanges();
            //Console.WriteLine(editor.CurrentText);





            Originator originatorOne = new Originator("0.0", "One");
            Caretake caretakeOne = new Caretake(originatorOne);
            caretakeOne.Backup();
            originatorOne.DoSomething(); //alter state
            originatorOne.ShowState();
            caretakeOne.Backup();
            originatorOne.DoSomething(); //alter state
            originatorOne.ShowState();


            caretakeOne.ShowHistory();
            caretakeOne.Undo();
            originatorOne.ShowState();


        }
    }
}


