using DesignPatterns.Behavioural.Observer.interfaces;

namespace DesignPatterns.Behavioural.Observer.model
{
    public class ConcreteObserverB : IObserver
    {
        public string Name { get; set; }

        public ConcreteObserverB(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }

        public void Update(ISubject subject)
        {
            if ((subject as Subject).GetState() > 3)
            {
                Console.WriteLine($"Observer {Name}: Reacted to the event.");
            }
        }
    }
}
