using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welconme to Day 16 Programs\n");
            Console.WriteLine("Please enter the size of the array you want to sort using bubble sort\n");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] Number = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Please enter the {0} number", i + 1);
                Number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your array without sort is: " + string.Join(" ", Number));

            BubbleSort sort = new BubbleSort(Number);
            sort.Sort();

        }
    }
}
