using NUnit.Framework.Internal;

namespace Exam.Tests;

public class StructSortTest
{
    private readonly record struct Data(int Value, string Name);

    private class DataComparer : IComparer<Data>
    {
        public int Compare(Data x, Data y)
            => x.Value.CompareTo(y.Value);
    }

    private static readonly DataComparer comparer = new();

    [Test]
    public void EmptyTest()
    {
        var list = new List<Data>();
        var result = InsertionSort.Sort(list, StructSortTest.comparer);
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Empty);
            Assert.That(StructSortTest.IsSorted(result), Is.True);
        });
    }

    [Test]
    public void SortedTest()
    {
        var list = new List<Data>() { new Data(1, "name1"), new Data(2, "name2"), new Data(3, "name3"), new Data(4, "name4"), new Data(5, "name5") };
        var result = InsertionSort.Sort(list, StructSortTest.comparer);
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EquivalentTo(list));
            Assert.That(StructSortTest.IsSorted(result), Is.True);
        });
    }

    [Test]
    public void ReverseTest()
    {
        var list = new List<Data>() { new Data(5, "name1"), new Data(4, "name2"), new Data(3, "name3"), new Data(2, "name4"), new Data(1, "name5") };
        var result = InsertionSort.Sort(list, StructSortTest.comparer);

        var sortedList = new List<Data>() { new Data(1, "name5"), new Data(2, "name4"), new Data(3, "name3"), new Data(4, "name2"), new Data(5, "name1") };
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EquivalentTo(sortedList));
            Assert.That(StructSortTest.IsSorted(result), Is.True);
        });
    }

    [Test]
    public void SortTest()
    {
        var list = new List<Data>() { new Data(-5, "name1"), new Data(12, "name2"), new Data(46, "name3"), new Data(0, "name4"), new Data(46, "name5") };
        var result = InsertionSort.Sort(list, StructSortTest.comparer);

        var sortedList = new List<Data>() { new Data(-5, "name1"), new Data(0, "name4"), new Data(12, "name2"), new Data(46, "name3"), new Data(46, "name5") };
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EquivalentTo(sortedList));
            Assert.That(StructSortTest.IsSorted(result), Is.True);
        });
    }

    private static bool IsSorted(IList<Data> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i].Value > list[i + 1].Value)
            {
                return false;
            }
        }

        return true;
    }
}