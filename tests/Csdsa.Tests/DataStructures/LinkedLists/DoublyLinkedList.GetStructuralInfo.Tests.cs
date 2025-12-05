using Csdsa.DataStructures.LinkedLists;
using Xunit;

namespace Csdsa.Tests.DataStructures.LinkedLists;

public class DoublyLinkedListGetStructuralInfoTests
{
    private static DoublyLinkedList<int> NewList(params int[] items)
    {
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.AddRange(items);
        return list;
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3 }, 3, 1)]
    [InlineData(new[] { 1, 2, 3, 4 }, 4, 2)]
    public void GetStructuralInfo_Returns_Correct_Length_And_Mid(
        int[] data,
        int expectedLength,
        int expectedMidIndex)
    {
        DoublyLinkedList<int> list = NewList(data);

        (int length, int mid) = list.GetStructuralInfo();

        Assert.Equal(expectedLength, length);
        Assert.Equal(expectedMidIndex, mid);
    }
}
