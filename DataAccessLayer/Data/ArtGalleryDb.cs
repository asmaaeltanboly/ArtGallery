using DataAccessLayer.Entities.ArtWork;
using DataAccessLayer.Entities.Communication;
using DataAccessLayer.Entities.Content;
using DataAccessLayer.Entities.Event;
using DataAccessLayer.Entities.Interactions;
using DataAccessLayer.Entities.Orders;
using DataAccessLayer.Entities.User;
using DataAccessLayer.Entities.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace DataAccessLayer
{ 
public class ArtGalleryDb : IdentityDbContext<ApplicationUser>
{
    public ArtGalleryDb(DbContextOptions<ArtGalleryDb> options) : base(options)
    {
    }
    public DbSet<Paint> Paints { get; set; }
    public DbSet<Sculpture> Sculptures { get; set; }
    public DbSet<PaintStock> PainstStock { get; set; }
    public DbSet<SculptureStock> SculpturesStock { get; set; }
    public DbSet<Article> Articles { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<ChatRoom> ChatRooms { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<PublishEvent> PublishEvents { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Reaction> Reactions { get; set; }
    public DbSet<ReactionType> ReactionTypes { get; set; }
    public DbSet<Rate> Rates { get; set; }
    public DbSet<Share> Shares { get; set; }
    public DbSet<FavouriteArtWorkGallery> FavouriteArtWorkGalleries { get; set; }
    public DbSet<FavouriteArtWorkStore> FavouriteArtWorkStores { get; set; }
    public DbSet<UserFollow> FollowersAndFollowing { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Payment> Payments { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserFollow>()
                .HasKey(uf => uf.Id);

            modelBuilder.Entity<UserFollow>()
                .HasOne(uf => uf.Follower)
                .WithMany(u => u.Following)
                .HasForeignKey(uf => uf.FollowerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserFollow>()
                .HasOne(uf => uf.Following)
                .WithMany(u => u.Followers)
                .HasForeignKey(uf => uf.FollowingId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Comment>()
                  .HasOne(c => c.ParentComment)
                  .WithMany(c => c.Replies)
                  .HasForeignKey(c => c.ParentCommentId)
                  .OnDelete(DeleteBehavior.Restrict);


        }
    }
}