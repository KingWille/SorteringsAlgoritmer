namespace SorteringsAlgoritmer
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] rndArr = { 3, 5, 2, 1, 7, 6, 3, 4 };
            int[] rndArr2 = { 5, 4, 2, 1, 5 };
            int[] rndArr3 = { 3, 10, 16, 23, 25, 50, 2, 1 };
            //Mergesort.PrintArray(rndArr3);
            //Mergesort.Sort(rndArr3, 0, rndArr3.Length - 1);

            //Mergesort.PrintArray(rndArr3);

            Quicksort.PrintArray(rndArr);
            Quicksort.Sort(rndArr, rndArr.Length - 1, 0);
            Quicksort.PrintArray(rndArr);
        }
    }
}
