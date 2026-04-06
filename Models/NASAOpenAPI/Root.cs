using System.Text.Json.Serialization;

namespace Models.NASAOpenAPI
{
    public class Root
    {
        [JsonPropertyName("collection")]
        public Collection? Collection { get; set; }
    }
}