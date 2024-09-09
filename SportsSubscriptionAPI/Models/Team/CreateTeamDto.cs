using System.ComponentModel.DataAnnotations;

namespace SportsSubscriptionAPI.Models.Team
{
    public class CreateTeamDto
    {
        [Required]
        public string Name { get; set; }
    }
}
