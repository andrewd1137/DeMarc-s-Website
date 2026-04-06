using System.Text.Json.Serialization;

namespace Models.NASAOpenAPI
{
    public class Datum
    {
        [JsonPropertyName("Center")]
        public string? center { get; set; }

        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("keywords")]
        public List<string>? Keywords { get; set; }

        [JsonPropertyName("media_type")]
        public string? MediaType { get; set; }

        [JsonPropertyName("nasa_id")]
        public string? NasaId { get; set; }

        [JsonPropertyName("photographer")]
        public string? Photographer { get; set; }
        
        [JsonPropertyName("title")]
        public string? Title { get; set; }
    }
}