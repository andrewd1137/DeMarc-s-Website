using System.Text.Json.Serialization;

namespace Models.NASAOpenAPI
{
    public class Link
    {
        [JsonPropertyName("href")]
        public string? Href { get; set; }
        [JsonPropertyName("rel")]
        public string? Rel { get; set; }

        [JsonPropertyName("render")]
        public string? Render { get; set; }

        [JsonPropertyName("width")]
        public int? Width { get; set; }

        [JsonPropertyName("size")]
        public int? Size { get; set; }

        [JsonPropertyName("height")]
        public int? Height { get; set; }
        
        [JsonPropertyName("prompt")]
        public string? Prompt { get; set; }
    }
}