using System;

namespace task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var N = Convert.ToInt32(Console.ReadLine());
            var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            var myTable = new HashTable(5);

            for (int i = 0; i < N; i++)
            {
                myTable.Insert(arr[i]);
            }


            myTable.Display();
        }
    }
}