using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSort
{
    class MergeSort
    {
        private int[] temp;
        private int i, j, k;

        public void Merge(int[] Numbers, int low, int mid, int high, int arraySize)
        {
            temp = new int[arraySize];
            i = low;
            j = mid + 1;
            k = low;
            while (i <= mid && j <= high)
            {
                if (Numbers[i] <= (Numbers[j]))
                {
                    temp[k] = Numbers[i];
                    i = i + 1;
                }
                else
                {
                    temp[k] = Numbers[j];
                    j = j + 1;
                }
                k = k + 1;
            }
            if (i > mid)
            {
                while (j <= high)
                {
                    temp[k] = Numbers[j];
                    j = j + 1;
                    k = k + 1;
                }
            }
            else
            {
                while (i <= mid)
                {
                    temp[k] = Numbers[i];
                    i = i + 1;
                    k = k + 1;
                }
            }

            for (k = low; k <= high; k++)
            {
                Numbers[k] = temp[k];
            }
            Console.WriteLine("Array with sort is: " + string.Join(" ", Numbers));
        }

        public void mergeSort(int[] Number, int low, int high, int arraySize)
        {
            if (low < high)
            {
                int mid = ((low + high) / 2);
                mergeSort(Number, low, mid, arraySize);
                mergeSort(Number, mid + 1, high, arraySize);
                Merge(Number, low, mid, high, arraySize);
            }
        }
    }
}
