namespace AlgoReview.Search;

public static class BinarySearch
{
    public static int Search(int[] array, int target)
    {
        var left = 0;
        var right = array.Length - 1;

        while (left <= right)
        {
            var middle = (left + right) / 2;

            if (array[middle] == target)
            {
                return middle;
            }

            if (array[middle] < target)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return -1;
    }
}