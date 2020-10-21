using System.ComponentModel.DataAnnotations;

namespace MacroWeb.Models
{
    public class Connection
    {
        [Key]
        public int ConnectionId { get; set; }

        public int FollowerId { get; set; }
        public User Follower { get; set; }

        public int UserFollowedId { get; set; }
        public User UserFollowed { get; set; }
    }
}
