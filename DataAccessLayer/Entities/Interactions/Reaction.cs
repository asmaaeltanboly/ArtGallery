using DataAccessLayer.Entities.Event;
using DataAccessLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Interactions
{
    public class Reaction
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }

        public int ReactionTypeId { get; set; }
        public ReactionType ReactionType { get; set; }

        
        public int? PostId { get; set; }
        public Post Post { get; set; }

        public int? CommentId { get; set; }
        public Comment Comment { get; set; }

        //public int? ReplyId { get; set; }
        //public Reply Reply { get; set; }

        public int? EventId { get; set; }
        public PublishEvent Event { get; set; }
    }
}
