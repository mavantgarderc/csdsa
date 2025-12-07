using System;
using System.IO;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Deserializes JSON from the specified file into an instance of <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The target type.</typeparam>
    /// <param name="filePath">The path of the file to read.</param>
    /// <returns>An instance of <typeparamref name="T"/>.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="filePath"/> is <see langword="null"/>.
    /// </exception>
    public static T DeserializeFromFile<T>(string filePath)
    {
        ArgumentNullException.ThrowIfNull(filePath);

        string json = File.ReadAllText(filePath);
        return DeserializeFromJson<T>(json);
    }
}
