namespace AlgoReview.Sort;

public static class BubbleSort
{
    public static void Sort<T>(T[] array) where T : IComparable
    {
        for(var i = 0; i < array.Length; i++)
        {
            for (var j = 0; j < array.Length - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    (array[j], array[j+1]) = (array[j+1], array[j]);
                }
            }
        }
    }
}