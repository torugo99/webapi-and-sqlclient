#nullable disable warnings

using System.Text.Json.Serialization;

namespace WebApi.Models
{
    public class User
    {
        [JsonIgnore]
        [JsonPropertyName("user_id")]
        public Guid UserId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}