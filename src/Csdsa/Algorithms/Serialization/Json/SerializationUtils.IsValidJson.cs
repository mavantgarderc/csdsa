using System.Text.Json;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Determines whether the specified string is valid JSON.
    /// </summary>
    /// <param name="json">The JSON string to validate.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="json"/> is non-empty and valid JSON;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsValidJson(string json)
    {
        if (string.IsNullOrWhiteSpace(json))
        {
            return false;
        }

        try
        {
            using JsonDocument document = JsonDocument.Parse(json);
            _ = document.RootElement;
            return true;
        }
        catch (JsonException)
        {
            return false;
        }
    }
}
