namespace DesignPatterns.Structural.Composite
{
    public abstract class Sale
    {
  
        public abstract float GetPrice();

        public abstract void AddItem(Sale item);

        public abstract void RemoveItem(Sale item);

        public abstract Sale GetChild(int index);
    }
}
