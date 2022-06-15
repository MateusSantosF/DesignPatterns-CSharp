namespace DesignPatterns.Behavioural.chainOfResponsability.model
{
    public class BtnCancel:Component
    {

        public BtnCancel()
        {

        }

        public void SetToolText(string message)
        {
            base.ToolTipText = message;
        }
    }
}
