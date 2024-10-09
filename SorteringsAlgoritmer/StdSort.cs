using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class StdSort : IntSorter
{
    public void Sort(int[] a)
    {
        SortedDictionary<int, int> sortedDict = new SortedDictionary<int, int>();

        //Lägg till nycklar i dictionary
        for (int i = 0; i < a.Length; i++)
        {
            if (sortedDict.TryGetValue(a[i], out int count))
            {
                sortedDict[a[i]]++;
            }
            else
            {
                sortedDict.Add(a[i], 1);
            }
        }

        //int arrayIndexer = 0;
        var enumerator = sortedDict.GetEnumerator();
        var CurrentKey = enumerator.Current.Key;
        var CurrentValue = enumerator.Current.Value;
        //Lägg tillbaka nycklarna i arrayen
        for (int i = 0; i < a.Length; i++)
        {
            if (CurrentValue >= 1)
            {
                a[i] = CurrentKey;
                CurrentValue--;
            }
            else
            {
                enumerator.MoveNext();
                CurrentKey = enumerator.Current.Key;
                CurrentValue = enumerator.Current.Value;

                if (CurrentValue >= 1)
                {
                    a[i] = CurrentKey;
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
    }
}
