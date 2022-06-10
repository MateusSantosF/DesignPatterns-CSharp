using DesignPatterns.Behavioural.Observer.interfaces;

namespace DesignPatterns.Behavioural.Observer.model
{
    public class Subject : ISubject
    {
        private int State { get; set; } = 0;

        private List<IObserver> observers = new List<IObserver>();

        public Subject()
        {

        }
        public void Attach(IObserver observer)
        {
            Console.WriteLine($"Observer added {observer.GetName()}");
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine($"Observer Removed {observer.GetName()}");
            observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");
            observers.ForEach(ob =>
            {
                ob.Update(this);
            });
        }

        public void ChangeState(int stateStatus)
        {
            Console.WriteLine($"Change state for {stateStatus}");
            State = stateStatus;
            Notify();
        }

        public int GetState()
        {
            return State;
        }
    }
}
