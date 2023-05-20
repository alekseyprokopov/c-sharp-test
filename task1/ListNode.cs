using System;

namespace task1
{
    public class ListNode<T>
    {
        int value;
        ListNode<int> Next;

        public ListNode(int newValue)
        {
            this.value = newValue;
        }

        public void Insert(int newValue)
        {
            var NewNode = new ListNode<int>(newValue);
            this.Next = NewNode;
        }

        public int GetValue()
        {
            return this.value;
        }

        public ListNode<int> GetNext()
        {
            return this.Next;
        }
    }
}