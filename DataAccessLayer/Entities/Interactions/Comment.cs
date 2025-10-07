using DataAccessLayer.Entities.Content;
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
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // ربط بالكومنت الأساسي (لو هو رد)
        public int? ParentCommentId { get; set; }

        // الـ Navigation property للكومنت الأب
        public Comment ParentComment { get; set; }

        // الـ Navigation property للردود
        public List<Comment> Replies { get; set; } = new List<Comment>();

        // ربط بالمقال
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        // ربط باليوزر
        public string  UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }
        public int EventId { get; set; }
        public PublishEvent Event { get;set; }
        public int PostId { get; set; }
        public Post post { get;set; }


    }

}
