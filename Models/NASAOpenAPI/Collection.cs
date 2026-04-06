using System.Text.Json.Serialization;

namespace Models.NASAOpenAPI
{
    public class Collection
    {
        [JsonPropertyName("version")]
        public string? Version { get; set; }
        
        [JsonPropertyName("href")]
        public string? Href { get; set; }

        [JsonPropertyName("items")]
        public List<Item>? Items { get; set; }

        [JsonPropertyName("metadata")]
        public Metadata? Metadata { get; set; }

        [JsonPropertyName("links")]
        public List<Link>? Links { get; set; }
    }
}