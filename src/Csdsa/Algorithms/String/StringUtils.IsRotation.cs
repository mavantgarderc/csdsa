namespace Csdsa.Algorithms.Strings;

public static partial class StringUtils
{
    /// <summary>
    /// Determines whether <paramref name="rotated"/> is a rotation of <paramref name="original"/>.
    /// For example, <c>"erbottlewat"</c> is a rotation of <c>"waterbottle"</c>.
    /// </summary>
    /// <param name="original">The original string.</param>
    /// <param name="rotated">The candidate rotated string.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="rotated"/> is a rotation of
    /// <paramref name="original"/>; otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="original"/> or <paramref name="rotated"/> is <see langword="null"/>.
    /// </exception>
    public static bool IsRotation(string original, string rotated)
    {
        ArgumentNullException.ThrowIfNull(original);
        ArgumentNullException.ThrowIfNull(rotated);

        if (original.Length != rotated.Length)
        {
            return false;
        }

        string doubled = original + original;
        return doubled.Contains(rotated, StringComparison.Ordinal);
    }
}
