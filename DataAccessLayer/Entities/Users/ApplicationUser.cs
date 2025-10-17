using DataAccessLayer.Entities.ArtWork;
using DataAccessLayer.Entities.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.User
{
    public class ApplicationUser : IdentityUser
    {
        public string? SSN { get; set; }
        public string Bio { get; set; } = "No bio yet";
        public string? ProfileImgUrl { get; set; }

        public List<Paint> paints { get; set; }
        public List<Sculpture> Sculptures { get; set; }
        
        public List<UserFollow> Followers { get; set; } = new();
        public List<UserFollow> Following { get; set; } = new();
    }
}

