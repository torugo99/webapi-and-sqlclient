#nullable disable warnings

namespace WebApi.Models.Dtos
{
    public class ClientUpdateDto
    {
        public string name_client { get; set; }

        public string user_id { get; set; }
        
        public DateTime updated_at { get; set; }
    }
}