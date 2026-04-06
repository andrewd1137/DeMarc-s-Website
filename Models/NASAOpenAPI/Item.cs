using System.Text.Json.Serialization;

namespace Models.NASAOpenAPI
{
    public class Item
    {
        [JsonPropertyName("href")]
        public string? Href { get; set; }
        
        [JsonPropertyName("data")]
        public List<Datum>? Data { get; set; }

        [JsonPropertyName("links")]
        public List<Link>? Links { get; set; }
    }

}