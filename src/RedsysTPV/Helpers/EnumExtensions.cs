using RedsysTPV.Enums;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            if (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) is DescriptionAttribute d)
            {
                return d.Description;
            }

            return value.ToString();
        }
    }

    public class EnumDescriptionConverter<T>: JsonConverter<T>
    {
        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            writer.WriteStringValue((value as Enum)?.GetDescription() ?? null);
        }

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return (T)Enum.ToObject(typeof(T), Convert.ToInt32(reader.GetString()));
        }
    }

    public class EnumToThreeStringConverter<T> : JsonConverter<T>
    {
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (string.IsNullOrEmpty(value))
            {
                return (T)Enum.ToObject(typeof(T), 0);
            }
            return (T)Enum.ToObject(typeof(T), Convert.ToInt32(reader.GetString()));
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(Convert.ToInt32(value).ToString("D3", CultureInfo.InvariantCulture));
        }
    }
}
