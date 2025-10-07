
using System;
using DataAccessLayer.Entities.User;

namespace DataAccessLayer.Entities.Users
{
    public class UserFollow
    {
        public int Id { get; set; }

        public string FollowerId { get; set; }   // اللي بيعمل Follow
        public ApplicationUser Follower { get; set; }

        public string FollowingId { get; set; }  // اللي بيتعمله Follow
        public ApplicationUser Following { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

