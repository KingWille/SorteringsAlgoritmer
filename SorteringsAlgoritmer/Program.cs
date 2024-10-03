namespace SorteringsAlgoritmer
{
    internal class Program
    {
        public static InsertionSorter InSort = new InsertionSorter();
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int arrSize = 100000000;
            int[] rndArr = new int[arrSize];

            for (int i = 0; i < rndArr.Length; i++)
            {
                rndArr[i] = rnd.Next(0, arrSize);
            }

            //MergesortBetter.PrintArray(rndArr);

            DateTime start = DateTime.Now;
            //MergesortBetter.Sort(rndArr, 0, rndArr.Length - 1);
            QuicksortBetter.Sort(rndArr, 0, rndArr.Length - 1);
            //Mergesort.Sort(rndArr, 0, rndArr.Length - 1);
            //Quicksort.Sort(rndArr, 0, rndArr.Length - 1);
            DateTime end = DateTime.Now;

            //MergesortBetter.PrintArray(rndArr);
            Console.WriteLine("Total time: " + (end - start).TotalSeconds);
        }
    }
}
