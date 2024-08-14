using System.Text.Json;
using System.Text.Json.Serialization;

namespace D4C_API
{
    public class CustomJsonConverter : JsonConverter<Models.V1.Object>
    {
        public override Models.V1.Object? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, Models.V1.Object value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("id"); //TODO: change to uri
            writer.WriteStringValue(value.Uri.ToString());


            writer.WritePropertyName("http://www.w3.org/2000/01/rdf-schema#label");
            writer.WriteStringValue(value.Name);

            foreach (var property in value.Properties)
            {
                if (value.SelectedProperties is not null)
                {
                    if (value.SelectedProperties.Contains(property.Name, StringComparer.OrdinalIgnoreCase) || value.SelectedProperties.Contains(property.Uri.ToString(), StringComparer.OrdinalIgnoreCase))
                    {
                        writer.WritePropertyName(property.Uri.ToString());
                        JsonSerializer.Serialize(writer, property.Value);
                    }
                }
                else
                {
                    writer.WritePropertyName(property.Uri.ToString());
                    JsonSerializer.Serialize(writer, property.Value);
                }
            }

            writer.WriteEndObject();
        }
    }
}
