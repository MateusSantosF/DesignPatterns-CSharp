namespace DesignPatterns.Behavioural.chainOfResponsability.model
{
    public class Dialog:Container
    {

        private string ToolText { get; set; }

        public void SetToolText(string message)
        {
            ToolText = message;
        }

        public void ShowHelp()
        {
            if(ToolText is not null)
            {
                Console.WriteLine(ToolText);
            }
            else
            {
                base.ShowHelp();
            }
        }
    }
}
