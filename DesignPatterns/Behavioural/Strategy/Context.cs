using DesignPatterns.Behavioural.Strategy.interfaces;

namespace DesignPatterns.Behavioural.Strategy
{
    public class Context
    {

        private IStrategy _strategy;

        public Context() { }

        public void SetStrategy(IStrategy strategy)
        {
            string strategyName = strategy.GetType().ToString();
            strategyName = strategyName.Substring(strategyName.LastIndexOf('.') + 1, 3);
            Console.WriteLine("Strategy Mode: " + strategyName);
            _strategy = strategy;
        }

        public void DoSomething(int paramOne, int paramTwo)
        {
            _strategy.Execute(paramOne, paramTwo);
        }
    }
}
