using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Items items = new Items();
            items.addItem("Item1");
            items.addItem("Item2");
            items.addItem("Item3");
            foreach (string i in items)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
    public class Items : IEnumerable
    {
        int index = 0;
        string[] ItemsList = new string[10];
        public void addItem(string item)
        {
            ItemsList[index++] = item;
        }
        public void removeItem(int index)
        {
            ItemsList[index] = "";
        }
        public IEnumerator GetEnumerator()
        {
            return new ItemEnumerator(ref ItemsList);
        }
        class ItemEnumerator : IEnumerator
        {
            private string[] itemsList;
            int index = 0;
            public ItemEnumerator(ref string[] itemsList)
            {
                this.itemsList = itemsList;
            }

            public object Current { get { return this.itemsList[index++]; } }

            public bool MoveNext()
            {
                return index >= this.itemsList.Length ? false:true;
            }

            public void Reset()
            {
                index = 0;
            }
        }

       
    }
}
