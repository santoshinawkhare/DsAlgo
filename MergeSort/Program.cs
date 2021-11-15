using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Progam for sorting a array using merge sort\n");
            Console.WriteLine("Please enter size of the array you want\n");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] Numbers = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Please enter the {0} String", i + 1);
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array without sort is: " + string.Join(" ", Numbers));
            int low = 0;
             int high = Numbers.Length - 1;

            MergeSort sort = new MergeSort();
            sort.mergeSort(Numbers, low, high, N);
        }
    }
}
