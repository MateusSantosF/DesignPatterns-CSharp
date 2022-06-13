using DesignPatterns.Behavioural.Strategy.interfaces;

namespace DesignPatterns.Behavioural.Strategy.model
{
    public class SumStrategy : IStrategy
    {
        public void Execute(int paramOne, int paramTwo)
        {
           Console.WriteLine(paramOne + paramTwo);
        }
    }
}
