using System.Text;

namespace Csdsa.DataStructures.Arrays;

public partial class DynamicArray<T>
{
    /// <summary>
    /// Returns a string that represents the current dynamic array.
    /// </summary>
    /// <returns>
    /// A string representation of the contents of the dynamic array in the form
    /// <c>[item1, item2, ...]</c>. For an empty array, returns <c>[]</c>.
    /// </returns>
    public override string ToString()
    {
        if (_count == 0)
        {
            return "[]";
        }

        StringBuilder sb = new StringBuilder();
        sb.Append('[');

        for (int i = 0; i < _count; i++)
        {
            sb.Append(_items[i]);
            if (i < _count - 1)
            {
                sb.Append(", ");
            }
        }

        sb.Append(']');
        return sb.ToString();
    }
}
