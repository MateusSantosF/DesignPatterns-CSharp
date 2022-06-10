namespace DesignPatterns.Behavioural.Observer.interfaces
{
    public interface ISubject
    {

        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
}
