using DesignPatterns.Behavioural.Iterator.interfaces;

namespace DesignPatterns.Behavioural.Iterator.model
{
    public class NumbersCollection : ICollection
    {

        private int[] numbers;
        private bool Crescent;
        private int index;

        public NumbersCollection(int size, bool crescent)
        {
            numbers = new int[size];
            Crescent = crescent;
            index = 0;
        }

        public void AddInt(int e)
        {
            numbers[index++] = e;
        }

        public int[] GetItems()
        {
            return numbers;
        }

        public MyIterator GetIterator()
        {
            return new ConcreteIterator(this, Crescent);
        }

        public void MyFor(MyIterator iterator)
        {
            while (iterator.HasNext())
            {
                Console.WriteLine("i->"+iterator.GetNext());
            }
        }
    }
}
