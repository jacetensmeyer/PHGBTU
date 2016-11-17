using Phuket.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Phuket.DAL
{
    public class PageContext : DbContext
    {
        public DbSet<ContentBlockCategory> ContentBlockCategories { get; set; }
        public DbSet<ContentBlock> ContentBlocks { get; set; }
        public DbSet<MediaCategory> MediaCategories { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<PageSetting> PageSettings { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ContentBlockMedia> ContentBlockMedias { get; set; }
        public DbSet<ContentBlockTag> ContentBlockTags { get; set; }
        public DbSet<MediaTag> MediaTags { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //I dont think we need this next section now that we have models for the join tables
            /*modelBuilder.Entity<Media>().HasMany(c => c.ContentBlocks).WithMany(i => i.Medias)
           .Map(t => t.MapLeftKey("MediaID")
           .MapRightKey("ContentBlockID")
           .ToTable("ContentBlockMedia"));

            modelBuilder.Entity<Media>().HasMany(c => c.Tags).WithMany(i => i.Medias)
           .Map(t => t.MapLeftKey("MediaID")
           .MapRightKey("TagID")
           .ToTable("MediaTag"));

            modelBuilder.Entity<ContentBlock>().HasMany(c => c.Tags).WithMany(i => i.ContentBlocks)
           .Map(t => t.MapLeftKey("ContentBlockID")
           .MapRightKey("TagID")
           .ToTable("ContentBlockTag"));*/
        }
    }
}