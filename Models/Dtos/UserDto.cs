using System.Text.Json.Serialization;

#nullable disable warnings

namespace WebApi.Models.Dtos
{
    public class UserDto
    {   
        [JsonIgnore]
        public Guid user_id { get; set; }

        public string name_user { get; set; }

        public string email { get; set; }

        public DateTime created_at { get; set; }

    }
}