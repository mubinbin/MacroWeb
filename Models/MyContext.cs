using Microsoft.EntityFrameworkCore;
using MacroWeb.Models;
namespace MacroWeb.Models
{ 
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        // the "Monsters" table name will come from the DbSet variable name
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Comment> Comments { get; set; }
        // many to many tables
        public DbSet<Connection> Connections {get; set;}
        public DbSet<LikedMessage> LikedMessages {get; set;}
        public DbSet<LikedComment> LikedComments {get; set;}
    }
}