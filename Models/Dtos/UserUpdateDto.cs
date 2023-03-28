#nullable disable warnings

namespace WebApi.Models.Dtos
{
    public class UserUpdateDto
    {
        public string name_user { get; set; }

        public string email { get; set; }

        public DateTime updated_at { get; set; }
    }
}