using Csdsa.DataStructures.LinkedLists;
using Xunit;

namespace Csdsa.Tests.DataStructures.LinkedLists;

public class DoublyLinkedListAddRangeTests
{
    private static readonly string[] ExpectedAbc = { "a", "b", "c" };

    [Fact]
    public void AddRange_Appends_All_Items()
    {
        DoublyLinkedList<string> list = new DoublyLinkedList<string>();

        list.AddRange(new[] { "a", "b", "c" });

        Assert.Equal(ExpectedAbc, list.ToArray());
    }
}
