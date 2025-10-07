using DataAccessLayer.Entities.Orders;
using DataAccessLayer.Entities.User;
using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.ArtWork
{
    public class Sculpture
    {
        public int Id { get; set; }
        public string SculptureUrl { get; set; }
        public string Description { get; set; }
        public Category category { get; set; }
        public DateOnly CreatedAt { get; set; }
        public bool AvailableAtStore { get; set; }
        public List<SculptureStock> SculptureStocks { get; set; } = new List<SculptureStock>();

        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }
    }
}
