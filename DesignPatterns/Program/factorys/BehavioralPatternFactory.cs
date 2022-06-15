using DesignPatterns.Behavioural.chainOfResponsability.model;
using DesignPatterns.Behavioural.CommandPattern;
using DesignPatterns.Behavioural.CommandPattern.model;
using DesignPatterns.Behavioural.Iterator.interfaces;
using DesignPatterns.Behavioural.Iterator.model;
using DesignPatterns.Behavioural.Mediator;
using DesignPatterns.Behavioural.Mediator.model;
using DesignPatterns.Behavioural.Memento;
using DesignPatterns.Behavioural.Observer.model;
using DesignPatterns.Behavioural.Strategy;
using DesignPatterns.Behavioural.Strategy.model;
using DesignPatterns.Behavioural.Visitor;
using DesignPatterns.Behavioural.Visitor.model;
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

                    var copyButton = new Behavioural.CommandPattern.model.Button(new CopyCommand(editor));
                    var pasteButton = new Behavioural.CommandPattern.model.Button(new PasteCommand(editor));

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

                case Constants.STRATEGY:

                    Context context = new Context();
                    context.SetStrategy(new SumStrategy());
                    context.SetStrategy(new SubtractStrategy());
                    context.DoSomething(2, 2);

                    return string.Empty;
                case Constants.VISITOR:


                    Dot dot = new Dot(2, 2);
                    Square square = new Square(3, 3);
                    ConcreteVisitor v = new ConcreteVisitor();
                    square.Accept(v);

                    return string.Empty;

                case Constants.MEDIATOR:
                    SimpleDialog simpleDialog = new SimpleDialog(); //mediator

                    var btn = new Behavioural.Mediator.model.Button(simpleDialog);
                    Checkbox checkbox = new Checkbox(simpleDialog);

                    simpleDialog.RegisterComponent(btn);
                    simpleDialog.RegisterComponent(checkbox);

                    btn.Click();
                    checkbox.Click();

                    return string.Empty;

                case Constants.ITERATOR:
                    NumbersCollection collection = new NumbersCollection(5, false);
                    collection.AddInt(1);
                    collection.AddInt(2);
                    collection.AddInt(3);
                    collection.AddInt(4);
                    collection.AddInt(5);

                    MyIterator iterator = collection.GetIterator();
                    collection.MyFor(iterator);

                    return string.Empty;

                case Constants.COR:
                    Dialog dialog = new Dialog();
                    Panel panel = new Panel();
                    panel.SetToolText("Panel tool tip");

                    var cancelButton = new BtnCancel();

                    dialog.Add(cancelButton);
                    panel.Add(dialog);

                    cancelButton.ShowHelp();

                    return string.Empty;
                default:
                    return string.Empty;

            }
        }
    }
}
