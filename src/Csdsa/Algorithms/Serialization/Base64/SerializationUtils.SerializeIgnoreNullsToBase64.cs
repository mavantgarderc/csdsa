using System;
using System.Text;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Serializes the specified value to JSON while ignoring null properties and
    /// then encodes the JSON as a Base64 UTF-8 string.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="data">The value to serialize.</param>
    /// <returns>
    /// A Base64-encoded JSON string with null properties omitted.
    /// </returns>
    public static string SerializeIgnoreNullsToBase64<T>(T data)
    {
        string json = SerializeIgnoreNulls(data);
        byte[] bytes = Encoding.UTF8.GetBytes(json);
        return Convert.ToBase64String(bytes);
    }
}
