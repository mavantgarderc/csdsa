using System;
using System.Text;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Serializes the specified value to a UTF-8 encoded JSON byte array.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="data">The value to serialize.</param>
    /// <returns>A UTF-8 encoded JSON byte array.</returns>
    public static byte[] SerializeToBytes<T>(T data)
    {
        string json = SerializeToJson(data);
        return Encoding.UTF8.GetBytes(json);
    }
}
