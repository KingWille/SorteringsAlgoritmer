using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteringsAlgoritmer
{
    class StdSort
    {
        public static void Sort(int[] arr)
        {
            Console.WriteLine("Sort started");
            SortedDictionary<int, int> sortedDict = new SortedDictionary<int, int>();

            //Lägg till nycklar i dictionary
            for(int i = 0; i < arr.Length; i++) 
            {
                if(sortedDict.ContainsKey(arr[i]))
                {
                    sortedDict[arr[i]]++;
                }
                else
                {
                    sortedDict.Add(arr[i], 1);
                }
            }

            //int arrayIndexer = 0;
            var enumerator = sortedDict.GetEnumerator();
            var CurrentKey = enumerator.Current.Key;
            var CurrentValue = enumerator.Current.Value;
            //Lägg tillbaka nycklarna i arrayen
            for (int i = 0; i < arr.Length; i++)
            {
                if (CurrentValue >= 1)
                {
                    arr[i] = CurrentKey;
                    CurrentValue--;
                }
                else
                {
                    enumerator.MoveNext();
                    CurrentKey = enumerator.Current.Key;
                    CurrentValue = enumerator.Current.Value;

                    if (CurrentValue >= 1)
                    {
                        arr[i] = CurrentKey;
                        CurrentValue--;
                    }
                }
            }

            //foreach (int i in sortedDict.Keys)
            //{
            //    for(int j = 0; j < sortedDict[i]; j++)
            //    {
            //        arr[arrayIndexer] = i;
            //        arrayIndexer++;
            //    }
            //}

            Console.WriteLine("Sort finished");
        }
    }
}
