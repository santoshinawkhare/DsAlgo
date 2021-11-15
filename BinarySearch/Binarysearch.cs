using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    class Binarysearch
    {
        private string[] array;
        private string search;
        private int low, high, mid;

        public Binarysearch(string[] Array, string value)
        {
            this.array = Array;
            this.search = value;
            this.low = 0;
            this.high = array.Length - 1;
        }

        public int Search()
        {
            Console.WriteLine("Array without sorting is: " + string.Join(" ", this.array));
            Array.Sort(array);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Sorted Array is: " + string.Join(" ", this.array));

            while (low <= high)
            {
                this.mid = Convert.ToInt32((low + high) / 2);
                if (search == array[mid])
                    return mid;
                else if (search.CompareTo(array[mid]) < 0)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return -1;
        }
    }
}
