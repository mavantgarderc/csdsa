using System;
using System.Collections;
using System.Collections.Generic;
using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListEnumerationTests
{
    private static readonly string[] _expectedAbc = { "a", "b", "c" };

    [Fact]
    public void Enumerator_IteratesCorrectly()
    {
        ArrayList<string> list = new ArrayList<string> { "a", "b", "c" };
        List<string> result = new List<string>();

        foreach (string item in list)
        {
            result.Add(item);
        }

        Assert.Equal(_expectedAbc, result);
    }

    [Fact]
    public void Enumerator_DetectsModification_Throws()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3 };
        IEnumerator<int> enumerator = list.GetEnumerator();

        list.Add(4);

        Assert.Throws<InvalidOperationException>(() => enumerator.MoveNext());
    }

    [Fact]
    public void NonGenericEnumerator_Works()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3 };
        IEnumerable nonGeneric = list;
        IEnumerator enumerator = nonGeneric.GetEnumerator();

        List<object> results = new List<object>();
        while (enumerator.MoveNext())
        {
            results.Add(enumerator.Current);
        }

        Assert.Equal(3, results.Count);
        Assert.Equal(1, results[0]);
        Assert.Equal(2, results[1]);
        Assert.Equal(3, results[2]);
    }
}
