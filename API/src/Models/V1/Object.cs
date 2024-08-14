using System.Text.Json.Serialization;

namespace D4C_API.Models.V1
{
    [JsonConverter(typeof(CustomJsonConverter))]
    public class Object
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Uri Uri { get; set; }

        public string[]? SelectedProperties { get; set; }

        public List<Property> Properties { get; set; } = [];
    }
}
