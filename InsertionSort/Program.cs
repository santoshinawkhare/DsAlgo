using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welconme to Day 16 Programs\n");
            Console.WriteLine("Please enter size of the array you want\n");
            int N = Convert.ToInt32(Console.ReadLine());
            string[] Name = new string[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Please enter the {0} String", i + 1);
                Name[i] = Convert.ToString(Console.ReadLine());
            }
            InsertionSort sort = new InsertionSort(Name);
            sort.Sort();
        }
    }
}
