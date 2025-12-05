using System.Collections.Generic;
using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListCtorCollectionTests
{
    [Fact]
    public void Constructor_FromCollection_CopiesElements()
    {
        List<int> source = new List<int> { 1, 2, 3 };

        ArrayList<int> list = new ArrayList<int>(source);

        Assert.Equal(3, list.Count);
        Assert.Equal(source[1], list[1]);
    }

    [Fact]
    public void Constructor_FromEmptyCollection_CreatesEmptyList()
    {
        ArrayList<int> list = new ArrayList<int>(new List<int>());

        Assert.Empty(list);
        Assert.Equal(0, list.Capacity);
    }
}
