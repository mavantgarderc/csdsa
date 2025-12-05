using System.Collections.Generic;
using System.Linq;
using Csdsa.DataStructures.LinkedLists;
using Xunit;

namespace Csdsa.Tests.DataStructures.LinkedLists;

public class LinkedListExtensionsFunctionalTests
{
    private static readonly int[] Expected1491625 = { 1, 4, 9, 16, 25 };
    private static readonly int[] Expected24 = { 2, 4 };
    private static readonly int[] Expected45 = { 4, 5 };
    private static readonly int[] Expected123 = { 1, 2, 3 };

    private static DoublyLinkedList<int> NewList(params int[] items)
    {
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.AddRange(items);
        return list;
    }

    [Fact]
    public void Map_Filter_Reduce_ForEach_And_Partition_Work_As_Expected()
    {
        DoublyLinkedList<int> list = NewList(1, 2, 3, 4, 5);

        int[] squares = list.Map(x => x * x).Cast<int>().ToArray();
        Assert.Equal(Expected1491625, squares);

        int[] evens = list.Filter(x => x % 2 == 0).Cast<int>().ToArray();
        Assert.Equal(Expected24, evens);

        int sum = list.Reduce(0, (acc, value) => acc + value);
        Assert.Equal(15, sum);

        List<int> collected = new List<int>();
        list.ForEach(collected.Add);
        Assert.Equal(list.ToArray(), collected.ToArray());

        (ILinkedList<int> left, ILinkedList<int> right) = list.Partition(x => x <= 3);
        Assert.Equal(Expected123, left.ToArray());
        Assert.Equal(Expected45, right.ToArray());
    }
}
