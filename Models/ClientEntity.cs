#nullable disable warnings

namespace WebApi.Models
{
    public class Client
    {
        public Guid ClientId { get; set; }

        public string Name { get; set; }

        public Guid UserId { get; set; }

        public virtual User? User { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}