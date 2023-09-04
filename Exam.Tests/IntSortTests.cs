using NUnit.Framework.Internal;

namespace Exam.Tests;

public class IntSortTest
{
    [Test]
    public void EmptyTest()
    {
        var list = new List<int>();
        var result = InsertionSort.Sort(list, Comparer<int>.Default);
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Empty);
            Assert.That(IntSortTest.IsSorted(result), Is.True);
        });
    }

    [Test]
    public void SortedTest()
    {
        var list = new List<int>() { 1, 2, 3, 4, 5 };
        var result = InsertionSort.Sort(list, Comparer<int>.Default);
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EquivalentTo(list));
            Assert.That(IntSortTest.IsSorted(result), Is.True);
        });
    }

    [Test]
    public void ReverseTest()
    {
        var list = new List<int>() { 5, 4, 3, 2, 1 };
        var result = InsertionSort.Sort(list, Comparer<int>.Default);

        var sortedList = new List<int>() { 1, 2, 3, 4, 5 };
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EquivalentTo(sortedList));
            Assert.That(IntSortTest.IsSorted(result), Is.True);
        });
    }

    [Test]
    public void SortTest()
    {
        var list = new List<int>() { -5, 12, 46, 0, 46 };
        var result = InsertionSort.Sort(list, Comparer<int>.Default);

        var sortedList = new List<int>() { -5, 0, 12, 46, 46 };
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EquivalentTo(sortedList));
            Assert.That(IntSortTest.IsSorted(result), Is.True);
        });
    }

    private static bool IsSorted(IList<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] > list[i + 1])
            {
                return false;
            }
        }

        return true;
    }
}