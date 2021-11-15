using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welconme to Day 16 Programs\n");
            Console.WriteLine("Please enter size of the array you want\n");
            int N = Convert.ToInt32(Console.ReadLine());
            string[] str = new string[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Please enter the {0} String", i + 1);
                str[i] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("Please enter the string you wan to find\n");
            string name = Console.ReadLine();

            Binarysearch search = new Binarysearch(str, name);
            var result = search.Search();
            Console.WriteLine("----------------------");
            if (result == -1)
                Console.WriteLine("Word is not  found");
            else
                Console.WriteLine("{0} is found at {1} index value", name, result);
        }
    }
}
