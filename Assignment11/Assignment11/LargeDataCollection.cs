using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public class LargeDataCollection <L> : IDisposable
    {
        private List<L> Data;
        public LargeDataCollection(List<L> initialData)
        {
            Data = new List<L>(initialData);
        }
        public void Add(L item)
        {
            Data.Add(item);
        }
        public void Remove(L item)
        {
            Data.Remove(item);
        }
        public L GetItem(int index)
        {
            if (index >= 0 && index < Data.Count)
            {
                return Data[index];
            }
            throw new IndexOutOfRangeException("Index is out of range.");
        }
                
        public void Dispose()
        {
            Data = null;
            Console.WriteLine("The resources has been released from the collection");
        }
        public void showData()
        {
            Console.WriteLine("Total elements are :"+Data.Count);
            for(int i=0; i<Data.Count; i++)
            {
                Console.WriteLine($"Index {i} : {Data[i]}");
            }
        }
    }
}
