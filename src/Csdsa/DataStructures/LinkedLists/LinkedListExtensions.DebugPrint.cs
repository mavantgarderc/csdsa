namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <c>DebugPrint</c> extension for <see cref="ILinkedList{T}"/>.
/// </summary>
public static partial class LinkedListExtensions
{
    /// <summary>
    /// Writes diagnostic information about the linked list to the console.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="list">The list to inspect.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="list"/> is null.
    /// </exception>
    public static void DebugPrint<T>(this ILinkedList<T> list)
    {
        if (list == null)
        {
            ArgumentNullException.ThrowIfNull(list);
        }

        Console.WriteLine("LinkedList Count: " + list.Count);
        Console.WriteLine("Has Cycle: " + list.HasCycle());

        (int length, int midIndex) = list.GetStructuralInfo();
        Console.WriteLine("Structural Info - Length: " + length + ", Mid Index: " + midIndex);

        int index = 0;
        foreach (T item in list)
        {
            Console.WriteLine("[" + index + "]: " + item);
            index++;
        }
    }
}
