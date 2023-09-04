namespace Exam;

/// <summary>
/// Insertion sort is a sorting algorithm that builds the final sorted list one item at a time by comparisons.
/// </summary>
public static class InsertionSort
{
    /// <summary>
    /// Sort <paramref name="list"/> by <paramref name="cmp"/>.
    /// </summary>
    /// <typeparam name="T">Type of listed objects.</typeparam>
    /// <param name="list">Sorting list.</param>
    /// <param name="cmp">Comparator.</param>
    /// <returns>Returns sorted list.</returns>
    public static IList<T> Sort<T>(IList<T> list, IComparer<T> cmp)
    {
        var values = new List<T>(list);
        for (int i = 1; i < values.Count; i++)
        {
            var x = values[i];
            var j = i;
            while (j > 0 && cmp.Compare(values[j - 1], x) >= 0)
            {
                (values[j], values[j - 1]) = (values[j - 1], values[j]);
                j -= 1;
            }

            values[j] = x;
        }

        return values;
    }
}
