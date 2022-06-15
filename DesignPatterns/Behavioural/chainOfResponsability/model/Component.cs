using DesignPatterns.Behavioural.chainOfResponsability.interfaces;

namespace DesignPatterns.Behavioural.chainOfResponsability.model
{
    public abstract class Component : ContextualHelp
    {
        public string ToolTipText;
        public Container Container { get; set; }
        public void ShowHelp()
        {
            if(ToolTipText is null) 
            {
                if (Container is null)
                {
                    return;
                }
                Container.ShowHelp();
            }
            else
            {
                Console.WriteLine(ToolTipText);
            }
        }
    }
}
