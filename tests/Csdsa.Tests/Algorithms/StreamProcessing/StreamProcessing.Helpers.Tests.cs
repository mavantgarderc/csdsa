using System.Collections.Generic;
using System.Threading.Tasks;

using Csdsa.Algorithms.StreamProccessing;

namespace Csdsa.Tests.Algorithms.StreamProccessing;

public sealed partial class StreamProcessingTests
{
    private static async IAsyncEnumerable<T> ToAsyncEnumerable<T>(IEnumerable<T> source)
    {
        foreach (T item in source)
        {
            await Task.Yield();
            yield return item;
        }
    }

    private static readonly int[] Int32Array123 = { 1, 2, 3 };
    private static readonly int[] Int32Array1234 = { 1, 2, 3, 4 };
    private static readonly int[] Int32Array12345 = { 1, 2, 3, 4, 5 };
    private static readonly string[] StringArray = { "a", "aa", "b", "bb", "ccc" };
}
