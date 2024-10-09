namespace SorteringsAlgoritmer
{
    internal class Program
    {
        public static InsertionSorter InSort = new InsertionSorter();
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int arrSize = 100;
            int[] rndArr = new int[arrSize];

            for (int i = 0; i < rndArr.Length; i++)
            {
                rndArr[i] = rnd.Next(0, arrSize);
            }

            MergesortBetter.PrintArray(rndArr);

            DateTime start = DateTime.Now;
            //StdSort.Sort(rndArr);
            //MergesortBetter.Sort(rndArr);
            QuicksortBetter.Sort(rndArr);
            //Mergesort.Sort(rndArr);
            //Quicksort.Sort(rndArr);
            DateTime end = DateTime.Now;

            MergesortBetter.PrintArray(rndArr);
            Console.WriteLine("Total time: " + (end - start).TotalSeconds);
        }
    }
}
