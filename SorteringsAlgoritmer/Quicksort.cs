using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace SorteringsAlgoritmer
{
    internal class Quicksort
    {
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
        //funkar nästan
        public static void Sort(int[] arr, int hi, int lo)
        {
            if(hi > lo)
            {
                int p = arr[lo];

                int i = lo + 1;
                int j = hi;

                while(i < j)
                {
                    while(arr[i] < p && i < hi)
                    {
                        i++;
                    }

                    while (arr[j] > p)
                    {
                        j--;
                    }

                    Exchange(arr, i, j);
                }

                Exchange(arr, lo, j);

                Sort(arr, j - 1, lo);
                Sort(arr, hi, j + 1);
            }
        }

        private static void Exchange(int[] arr, int index1, int index2)
        {
            int i = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = i;
        }
    }
}
