#nullable disable warnings

using System.Text.Json.Serialization;

namespace WebApi.Models
{
    public class Client
    {
        [JsonIgnore]
        [JsonPropertyName("client_id")]
        public Guid ClientId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("user_id")]
        public Guid UserId { get; set; }

        [JsonIgnore]
        public virtual User? User { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}