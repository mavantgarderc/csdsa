using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Serializes the specified value to an XML string using <see cref="XmlSerializer"/>.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="data">The value to serialize.</param>
    /// <returns>An XML representation of <paramref name="data"/>.</returns>
    public static string SerializeToXml<T>(T data)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        using MemoryStream memory = new MemoryStream();
        serializer.Serialize(memory, data);
        return Encoding.UTF8.GetString(memory.ToArray());
    }

    /// <summary>
    /// Deserializes the specified XML string into an instance of <typeparamref name="T"/>,
    /// using an <see cref="XmlReader"/> with DTD processing disabled and no resolver.
    /// </summary>
    /// <typeparam name="T">The target type.</typeparam>
    /// <param name="xml">The XML payload.</param>
    /// <returns>An instance of <typeparamref name="T"/>.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="xml"/> is <see langword="null"/>.
    /// </exception>
    public static T DeserializeFromXml<T>(string xml)
    {
        ArgumentNullException.ThrowIfNull(xml);

        XmlSerializer serializer = new XmlSerializer(typeof(T));

        using StringReader stringReader = new StringReader(xml);
        XmlReaderSettings settings = new XmlReaderSettings
        {
            DtdProcessing = DtdProcessing.Prohibit,
            XmlResolver = null,
        };

        using XmlReader reader = XmlReader.Create(stringReader, settings);
        object result = serializer.Deserialize(reader);
        return (T)result!;
    }
}
