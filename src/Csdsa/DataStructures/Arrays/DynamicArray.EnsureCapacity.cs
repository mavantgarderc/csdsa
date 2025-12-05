namespace Csdsa.DataStructures.Arrays;

public partial class DynamicArray<T>
{
    /// <summary>
    /// Ensures that the dynamic array has at least the specified capacity.
    /// </summary>
    /// <param name="min">The minimum required capacity.</param>
    private void EnsureCapacity(int min)
    {
        if (_items.Length < min)
        {
            int newCapacity = _items.Length == 0 ? 4 : _items.Length * 2;

            if (newCapacity < min)
            {
                newCapacity = min;
            }

            Array.Resize(ref _items, newCapacity);
        }
    }
}
