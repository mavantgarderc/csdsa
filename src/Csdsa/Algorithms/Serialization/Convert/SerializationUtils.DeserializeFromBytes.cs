using System;
using System.Text;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Deserializes a UTF-8 encoded JSON byte array into an instance of <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The target type.</typeparam>
    /// <param name="bytes">The UTF-8 encoded JSON bytes.</param>
    /// <returns>An instance of <typeparamref name="T"/>.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="bytes"/> is <see langword="null"/>.
    /// </exception>
    public static T DeserializeFromBytes<T>(byte[] bytes)
    {
        ArgumentNullException.ThrowIfNull(bytes);

        string json = Encoding.UTF8.GetString(bytes);
        return DeserializeFromJson<T>(json);
    }
}
