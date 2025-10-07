using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Interactions
{
     public class ReactionType
    {
        public int Id { get; set; }
        public string Name { get; set; }     
        public string IconPath { get; set; } 

        public ICollection<Reaction> Reactions { get; set; }
    }
}
