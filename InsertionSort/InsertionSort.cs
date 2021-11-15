using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort
{
    class InsertionSort
    {
        private string[] array;
        private string temp;
        private int i, j;

        public InsertionSort(string[] Array)
        {
            this.array = Array;
        }
        public void Sort()
        {
            Console.WriteLine("Array without sorting is: " + string.Join(" ", this.array));
            Console.WriteLine("---------------------------------------------------------------------------------");
            for (i = 1; i < array.Length; i++)
            {
                temp = array[i];
                j = i - 1;
                while (j >= 0 && array[j].CompareTo(temp) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
            Console.WriteLine("Sorted array is: " + string.Join(" ", this.array));
        }
    }
}
