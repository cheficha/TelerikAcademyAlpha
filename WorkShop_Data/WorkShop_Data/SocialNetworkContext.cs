using SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WorkShop_Data
{
    public class SocialNetworkContext : DbContext
    {
        public SocialNetworkContext() : base("SocialNetwork")
        {

        }
        public DbSet<UserProfile> Profiles { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Friendship>()
            .HasRequired<UserProfile>(s => s.Sender)
            .WithMany()
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<Friendship>()
                .HasRequired<UserProfile>(s => s.Receiver)
                .WithMany()
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }


    }
}
