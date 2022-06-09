namespace DesignPatterns.Structural.Composite.model
{
    public class Box : Sale
    {

        public List<Sale> SaleList { get; set; }

        public Box()
        {
            SaleList = new List<Sale>();
        }

        public override void AddItem(Sale item)
        {
            SaleList.Add(item);
        }

        public override Sale GetChild(int index )
        {
            return SaleList[index];
        }

        public override float GetPrice()
        {
            float price = 0;

            SaleList.ForEach(item =>
            {
                price+= item.GetPrice();
            });

            return price;
        }

        public override void RemoveItem(Sale item)
        {
            SaleList.Remove(item);
        }
    }
}
