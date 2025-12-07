using System;
using System.IO;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Serializes the specified value to a JSON file.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="data">The value to serialize.</param>
    /// <param name="filePath">The file path to write to.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="filePath"/> is <see langword="null"/>.
    /// </exception>
    public static void SerializeToFile<T>(T data, string filePath)
    {
        ArgumentNullException.ThrowIfNull(filePath);

        string json = SerializeToJson(data);
        File.WriteAllText(filePath, json);
    }
}
