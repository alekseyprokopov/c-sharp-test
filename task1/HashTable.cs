using System;
using System.Text;

namespace task1
{
    public class HashTable
    {
        public ListNode<int>[] values;

        public HashTable(int size)
        {
            this.values = new ListNode<int>[size];
        }


        public void Insert(int newValue)
        {
            var key = toHash(newValue);
            var node = this.values[key];


            if (node == null)
            {
                var newNode = new ListNode<int>(newValue);
                this.values[key] = newNode;
                return;
            }

            while (node.GetNext() != null)
            {
                node = node.GetNext();
            }

            node.Insert(newValue);
        }

        private int toHash(int value)
        {
            return value % this.values.Length;
        }

        public void Display()
        {
            for (var i = 0; i < this.values.Length; i++)
            {
                var sb = new StringBuilder(i + ": ");
                var tmp = values[i];
                while (tmp != null)
                {
                    sb.Append(tmp.GetValue() + " ");
                    tmp = tmp.GetNext();
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}