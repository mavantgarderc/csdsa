namespace Csdsa.DataStructures.ArrayList;

public partial class ArrayListUtils<T>
{
    /// <summary>
    /// Copies the elements of the list to a new array.
    /// </summary>
    /// <returns>
    /// A new array containing copies of the elements of the list.
    /// </returns>
    public T[] ToArray()
    {
        if (_size == 0)
        {
            return default;
        }

        T[] array = new T[_size];
        Array.Copy(_items, array, _size);

        return array;
    }
}
