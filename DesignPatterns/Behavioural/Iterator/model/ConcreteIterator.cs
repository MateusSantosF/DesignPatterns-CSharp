using DesignPatterns.Behavioural.Iterator.interfaces;

namespace DesignPatterns.Behavioural.Iterator.model
{
    public class ConcreteIterator : MyIterator
    {

        private ICollection _collection;
        private bool _crescent;
        private int CurrentIndex;

        public ConcreteIterator(ICollection collection, bool crescent)
        {
            _collection = collection;
            _crescent = crescent;

            if (crescent)
            {
                CurrentIndex = 0;
            }
            else
            {
                CurrentIndex = collection.GetItems().Length-1;
            }
               
        }
        public int GetNext()
        {
            if(_crescent)
                return _collection.GetItems()[CurrentIndex++];
            return _collection.GetItems()[CurrentIndex--];
        }

        public bool HasNext()
        {
            if(_crescent)
                return CurrentIndex < _collection.GetItems().Length;
            return CurrentIndex >= 0;
        }
    }
}
