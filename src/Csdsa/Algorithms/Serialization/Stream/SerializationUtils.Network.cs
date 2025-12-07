using System;
using System.IO;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Serializes the specified value to a network stream as JSON.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="data">The value to serialize.</param>
    /// <param name="networkStream">The network stream to write to.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="networkStream"/> is <see langword="null"/>.
    /// </exception>
    public static void SerializeToNetwork<T>(T data, Stream networkStream)
    {
        ArgumentNullException.ThrowIfNull(networkStream);
        SerializeToStream(data, networkStream);
    }

    /// <summary>
    /// Deserializes JSON from the specified network stream into an instance of <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The target type.</typeparam>
    /// <param name="networkStream">The network stream to read from.</param>
    /// <returns>An instance of <typeparamref name="T"/>.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="networkStream"/> is <see langword="null"/>.
    /// </exception>
    public static T DeserializeFromNetwork<T>(Stream networkStream)
    {
        ArgumentNullException.ThrowIfNull(networkStream);
        return DeserializeFromStream<T>(networkStream);
    }
}
