namespace Csdsa.DataStructures.Arrays;

/// <summary>
/// Represents a resizable array of elements that grows as items are added.
/// <para>
/// This type illustrates a classic dynamic array data structure:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>Elements are stored in a contiguous underlying array.</description>
///   </item>
///   <item>
///     <description>
///     Capacity grows automatically when required, typically by doubling,
///     giving amortized O(1) time for appending elements.
///     </description>
///   </item>
///   <item>
///     <description>
///     Provides index-based access, insertion, and removal operations similar
///     to a simple list.
///     </description>
///   </item>
/// </list>
/// <para>
/// Supported operations include:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>Adding elements to the end.</description>
///   </item>
///   <item>
///     <description>Inserting and removing elements at specified indices.</description>
///   </item>
///   <item>
///     <description>Clearing the collection.</description>
///   </item>
///   <item>
///     <description>Searching for elements with <c>IndexOf</c> and <c>Contains</c>.</description>
///   </item>
///   <item>
///     <description>Index-based get and set operations.</description>
///   </item>
///   <item>
///     <description>A string representation of the contents.</description>
///   </item>
/// </list>
/// </summary>
/// <typeparam name="T">The type of elements in the array.</typeparam>
public partial class DynamicArray<T>
{
    private T[] _items;
    private int _count;
}
