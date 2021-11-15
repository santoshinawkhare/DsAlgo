using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    class BubbleSort
    {
        private int[] array;
        private int i, j, temp;

        public BubbleSort(int[] Array)
        {
            this.array = Array;
        }

        public void Sort()
        {
            Console.WriteLine("-------------------------------------------------------------------");
            for (i = 0; i < array.Length - 1; i++)
            {
                int flag = 0;
                for (j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = 1;
                    }
                    if (flag == 0)
                        break;
                }
            }
            Console.WriteLine("Sorted array is: " + string.Join(" ", this.array));
        }
    }
}
