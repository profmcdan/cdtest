namespace AlgoReview.Search;

public static class LinearSearch
{
    public static int Search(int[] array, int target)
    {
        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }

        return -1;
    }
}