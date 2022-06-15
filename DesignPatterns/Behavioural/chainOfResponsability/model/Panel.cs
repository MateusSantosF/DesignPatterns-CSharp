namespace DesignPatterns.Behavioural.chainOfResponsability.model
{
    public class Panel:Container
    {
        public void SetToolText(string message)
        {
            base.ToolTipText = message;
        }

        public void ShowHelp()
        {
            if(ToolTipText is not null)
            {
                Console.WriteLine(ToolTipText);
            }
            else
            {
                base.ShowHelp();
            }
        }
    }
}
