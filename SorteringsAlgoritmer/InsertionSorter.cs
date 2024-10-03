namespace SorteringsAlgoritmer
{
    public class InsertionSorter : IntSorter
    {
        public void Sort(int[] a, int lo, int hi)
        {
            int N = (hi + 1) - lo;
            for (int i = lo; i < N; i++)
            {
                for (int j = i; j > 0 && a[j] < a[j - 1]; j--)
                {
                    int x = a[j]; a[j] = a[j - 1]; a[j - 1] = x;
                }
            }
        }
    }
}
