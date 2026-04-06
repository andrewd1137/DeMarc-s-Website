using System.Text.Json.Serialization;

namespace Models.NASAOpenAPI
{
    public class Metadata
    {
        [JsonPropertyName("total_hits")]
        public int? TotalHits { get; set; }
    }
}