﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;


internal class Quicksort : IntSorter
{
    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }

    public void Sort(int[] a)
    {
        StartSort(a, 0, a.Length - 1);
    }
    private void StartSort(int[] arr, int lo, int hi)
    {
        if (hi > lo)
        {
            int p = MedianOfThree(arr, lo, hi);

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
    }

    int MedianOfThree(int[] arr, int lo, int hi)
    {
        int mid = lo + (hi - lo) / 2;

        if (arr[lo] > arr[mid]) Exchange(arr, lo, mid);
        if (arr[lo] > arr[hi]) Exchange(arr, lo, hi);
        if (arr[mid] > arr[hi]) Exchange(arr, mid, hi);

        Exchange(arr, mid, lo);
        return arr[lo];
    }
    private void Exchange(int[] arr, int index1, int index2)
    {
        int i = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = i;
    }
}

