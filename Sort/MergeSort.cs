namespace AlgoReview.Sort;

public static class MergeSort
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

        int mid = (start + end) / 2;
        Sort(array, start, mid);
        Sort(array, mid + 1, end);
        Merge(array, start, mid, end);
    }
    
    private static void Merge<T>(T[] array, int start, int mid, int end) where T : IComparable<T>
    {
        T[] temp = new T[end - start + 1];
        int i = start;
        int j = mid + 1;
        int k = 0;
        while (i <= mid && j <= end)
        {
            if (array[i].CompareTo(array[j]) < 0)
            {
                temp[k++] = array[i++];
            }
            else
            {
                temp[k++] = array[j++];
            }
        }

        while (i <= mid)
        {
            temp[k++] = array[i++];
        }

        while (j <= end)
        {
            temp[k++] = array[j++];
        }

        for (var l = 0; l < temp.Length; l++)
        {
            array[start + l] = temp[l];
        }
    }
}