namespace D4C_API.Models.V1
{
    public class Property
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Uri Uri { get; set; }

        public object Value { get; set; }

        public string Unit { get; set; }

        public List<Property> Properties { get; set; } = new List<Property>();
    }
}
