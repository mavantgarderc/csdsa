namespace Csdsa.Algorithms.Strings;

public static partial class StringUtils
{
    /// <summary>
    /// Searches for the first occurrence of <paramref name="target"/> within <paramref name="source"/>
    /// using a naive substring scan.
    /// </summary>
    /// <param name="source">The string to search.</param>
    /// <param name="target">The substring to locate.</param>
    /// <returns>
    /// The zero-based index of the first occurrence of <paramref name="target"/> in
    /// <paramref name="source"/>, or -1 if the substring is not found or if either
    /// string is empty.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> or <paramref name="target"/> is <see langword="null"/>.
    /// </exception>
    public static int IndexOfSubstring(string source, string target)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(target);

        if (source.Length == 0 || target.Length == 0)
        {
            return -1;
        }

        if (target.Length > source.Length)
        {
            return -1;
        }

        for (int i = 0; i <= source.Length - target.Length; i++)
        {
            int j = 0;

            while (j < target.Length && source[i + j] == target[j])
            {
                j++;
            }

            if (j == target.Length)
            {
                return i;
            }
        }

        return -1;
    }
}
