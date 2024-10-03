﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteringsAlgoritmer
{
    internal class MergesortBetter
    {
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
        public static void Sort(int[] arr, int lo, int hi)
        {
            if (lo < hi)
            {
                if (hi - lo > 100)
                {
                    int mid = lo + (hi - lo) / 2;

                    Sort(arr, lo, mid);
                    Sort(arr, mid + 1, hi);

                    Merge(arr, lo, hi, mid);
                }
                else
                {
                    Program.InSort.Sort(arr, lo, hi);
                }
            }
        }

        public static void Merge(int[] arr, int lo, int hi, int mid)
        {
            //Skapar en höger och en vänster array
            int[] tempArrLeft = new int[mid - lo + 1];
            int[] tempArrRight = new int[hi - mid];

            //Kopierar informationen till arrayerna
            for (int index = 0; index < tempArrLeft.Length; index++)
            {
                tempArrLeft[index] = arr[lo + index];
            }

            for (int index = 0; index < tempArrRight.Length; index++)
            {
                tempArrRight[index] = arr[mid + 1 + index];
            }

            int i, j, k;
            i = 0;
            j = 0;
            k = lo;

            //Jämför värdena och lägger in dem i orginal arrayn
            while (k <= hi)
            {
                if (j >= tempArrRight.Length)
                {
                    arr[k] = tempArrLeft[i];
                    i++;
                }
                else if (i >= tempArrLeft.Length)
                {
                    arr[k] = tempArrRight[j];
                    j++;
                }
                else if (tempArrRight[j] < tempArrLeft[i])
                {
                    arr[k] = tempArrRight[j];
                    j++;
                }
                else if (tempArrRight[j] > tempArrLeft[i])
                {
                    arr[k] = tempArrLeft[i];
                    i++;
                }
                else
                {
                    arr[k] = tempArrLeft[i];
                    i++;
                }

                k++;
            }
        }
    }
}
