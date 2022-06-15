namespace DesignPatterns.Behavioural.chainOfResponsability.model
{
    public abstract class Container:Component
    {
        public void Add(Component component)
        {
            component.Container = this;
 
        }
    }
}
