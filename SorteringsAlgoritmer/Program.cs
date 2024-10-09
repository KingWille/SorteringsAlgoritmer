namespace SorteringsAlgoritmer
{
    internal class Program
    {
        public static InsertionSorter InSort = new InsertionSorter();
        static void Main(string[] args)
        {
            Random rnd = new Random();
            MergesortBetter mrgb = new MergesortBetter();
            QuicksortBetter qckb = new QuicksortBetter();
            StdSort sort = new StdSort();
            int arrSize = 10000000;
            int[] rndArr = new int[arrSize];

          
            for (int i = 0; i < rndArr.Length; i++)
            {
                rndArr[i] = rnd.Next(0, arrSize);
            }

            Console.WriteLine("\n ------ \n");

            DateTime start = DateTime.Now;
            sort.Sort(rndArr);
            DateTime end = DateTime.Now;
            Console.WriteLine("Total time: " + (end - start).TotalSeconds);
        }
    }
}
