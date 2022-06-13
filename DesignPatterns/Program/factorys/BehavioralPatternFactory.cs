using DesignPatterns.Behavioural.CommandPattern;
using DesignPatterns.Behavioural.CommandPattern.model;
using DesignPatterns.Behavioural.Memento;
using DesignPatterns.Behavioural.Observer.model;
using DesignPatterns.Program.factorys.interfaces;


namespace DesignPatterns.Program.factorys
{
    public class BehavioralPatternFactory : IFactory
    {
        public string Show(string patternName)
        {
            switch (patternName)
            {
                case Constants.COMMAND:
                    Editor editor = new Editor();
                    Button copyButton = new Button(new CopyCommand(editor));
                    Button pasteButton = new Button(new PasteCommand(editor));

                    editor.CurrentText = "Hello";
                    editor.SelectedText = "World!";


                    copyButton.Click();
                    pasteButton.Click();
                    Console.WriteLine(editor.CurrentText);
                    editor.UndoChanges();
                    Console.WriteLine(editor.CurrentText);

                    return string.Empty;
                case Constants.OBSERVER:
                    Subject subject = new Subject();

                    ConcreteObserverA observerA = new ConcreteObserverA("Observer A");
                    ConcreteObserverA observerA2 = new ConcreteObserverA("Observer A2");

                    ConcreteObserverB observerB = new ConcreteObserverB("Observer B");

                    subject.Attach(observerA);
                    subject.Attach(observerA2);
                    subject.Attach(observerB);

                    subject.ChangeState(2);
                    subject.ChangeState(4);

                    return string.Empty;

                case Constants.MEMENTO:
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

                    return string.Empty;

                default:
                    return string.Empty;

            }
        }
    }
}
