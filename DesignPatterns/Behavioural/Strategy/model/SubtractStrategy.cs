using DesignPatterns.Behavioural.Strategy.interfaces;

namespace DesignPatterns.Behavioural.Strategy.model
{
    public class SubtractStrategy : IStrategy
    {
        public void Execute(int paramOne, int paramTwo)
        {
           Console.WriteLine(paramOne - paramTwo);
        }
    }
}
