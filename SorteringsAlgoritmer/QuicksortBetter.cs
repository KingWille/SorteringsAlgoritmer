using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteringsAlgoritmer
{
    internal class QuicksortBetter
    {
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }

        public static void Sort(int[] arr)
        {
            StartSort(arr, 0, arr.Length - 1);
        }

        private static void StartSort(int[] arr, int lo, int hi)
        {
            if (hi > lo)
            {
                if (hi - lo > 100)
                {
                    int p = arr[lo];

                    int i = lo + 1;
                    int j = hi;

                    //Kör loopen medan i är mindre än j
                    while (i <= j)
                    {
                        //i++ medans indexen är mindre än eller lika med högsta index och värdet på indexen är mindre än pivoten
                        while (i <= hi && arr[i] < p)
                        {
                            i++;
                        }

                        //j-- medans index värdet är större än pivot
                        while (arr[j] > p)
                        {
                            j--;
                        }

                        //Bytar endast plats om i är mindre än eller lika med j
                        if (i <= j)
                        {
                            Exchange(arr, i, j);
                            i++;
                            j--;
                        }
                    }

                    //Sätter pivot på rätt ställe
                    Exchange(arr, lo, j);

                    StartSort(arr, lo, j - 1);
                    StartSort(arr, j + 1, hi);
                }
                else
                {
                    //InSort
                    int N = (hi + 1) - lo;
                    for (int i = lo; i < N; i++)
                    {
                        for (int j = i; j > 0 && arr[j] < arr[j - 1]; j--)
                        {
                            int x = arr[j]; arr[j] = arr[j - 1]; arr[j - 1] = x;
                        }
                    }
                }
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
