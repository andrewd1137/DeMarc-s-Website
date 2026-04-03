using System.Text.Json.Serialization;

namespace Models.NASAOpenAPI
{
    public class APOD
    {
        public string? Copyright { get; set; }
        public DateOnly? Date { get; set; }
        public string? Explanation { get; set; }
        public string? HDurl { get; set; }
        [JsonPropertyName("media_type")]
        public string? MediaType { get; set; }
        [JsonPropertyName("service_version")]
        public string? ServiceVersion { get; set; }
        public string? Title { get; set; }
        public string? URL { get; set; }
    }
}