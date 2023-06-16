namespace AlgoReview.Sort;

public static class QuickSort
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        Sort(array, 0, array.Length - 1);
    }
    
    private static void Sort<T>(T[] array, int start, int end) where T : IComparable<T>
    {
        if (start >= end)
        {
            return;
        }

        int pivot = Partition(array, start, end);
        Sort(array, start, pivot - 1);
        Sort(array, pivot + 1, end);
    }
    
    private static int Partition<T>(T[] array, int start, int end) where T : IComparable<T>
    {
        T pivot = array[end];
        int i = start;
        for (int j = start; j < end; j++)
        {
            if (array[j].CompareTo(pivot) < 0)
            {
                Swap(array, i, j);
                i++;
            }
        }

        //Swap(array, i, end);
        (array[i], array[end]) = (array[end], array[i]);
        return i;
    }
    
    private static void Swap<T>(T[] array, int i, int j)
    {
        (array[i], array[j]) = (array[j], array[i]);
    }
}