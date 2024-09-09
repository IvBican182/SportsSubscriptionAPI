using System.ComponentModel.DataAnnotations.Schema;

namespace SportsSubscriptionAPI.Data
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Role { get; set; }

        public string Email { get; set; }

        [ForeignKey(nameof(TeamId))]

        public int TeamId { get; set; }

        public Team Team { get; set; }

        
    }
}
