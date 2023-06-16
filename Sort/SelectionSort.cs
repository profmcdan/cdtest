namespace AlgoReview.Sort;

public static class SelectionSort
{
    public static void Sort<T>(T[] array) where T : IComparable
    {
        for (var i = 0; i < array.Length; i++)
        {
            int minIndex = i;
            T minValue = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                if(array[j].CompareTo(minValue) < 0)
                {
                    minIndex = j;
                    minValue = array[j];
                }
            }
            (array[i], array[minIndex]) = (array[minIndex], array[i]);
        }
    }
}