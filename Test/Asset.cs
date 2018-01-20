namespace Test
{
    public abstract class Asset
    {
        public string Name;

        public virtual decimal Liability => 10000;
        
        public abstract decimal NetValue { get; }
        
    }


    public class Stock : Asset
    {
        public long SharesOwned;
        public decimal CurrentPrice;
        
        
        public override decimal NetValue => CurrentPrice * SharesOwned;
    }


    public class House : Asset
    {
        public decimal Mortgage;

        public override decimal Liability => base.Liability + Mortgage;
        
        public override decimal NetValue { get; }
    }


    class Sentence
    {
         string[] words = "The quick brown fox".Split();

        public string this[int wordNum] // Indexer
        {
            get { return words[wordNum];  }
            set { words[wordNum] = value; }
        }
    }


    public class Stack<T>
    {
        private int position;
        T[] data = new T[100];

        public void Push(T obj) => data[position++] = obj;
        public T Pop() => data[--position];

    }
    
    
}
