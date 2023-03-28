using System.Text.Json.Serialization;

#nullable disable warnings

namespace WebApi.Models.Dtos
{
    public class ClientDto
    {
        [JsonIgnore]
        public Guid client_id { get; set; }
        
        public string name_client { get; set; }

        public string user_id { get; set; }
        
        public DateTime created_at { get; set; }
    }
}