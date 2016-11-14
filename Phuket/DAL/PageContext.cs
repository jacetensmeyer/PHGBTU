using Phuket.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Phuket.DAL
{
    public class PageContext : DbContext
    {
        public DbSet<ContentCategory> ContentCategories { get; set; }
        public DbSet<ContentBlock> ContentBlocks { get; set; }
        public DbSet<MediaCategory> MediaCategories { get; set; }
        public DbSet<Media> MediaItems { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<PageSetting> Settings { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            //building the join table
           // modelBuilder.Entity<Course>().HasMany(c => c.Instructors).WithMany(i => i.Courses)
           //.Map(t => t.MapLeftKey("CourseID")
           //.MapRightKey("InstructorID")
           //.ToTable("CourseInstructor"));

            modelBuilder.Entity<Media>().HasMany(c => c.ContentBlocks).WithMany(i => i.MediaItems)
           .Map(t => t.MapLeftKey("MediaItemID")
           .MapRightKey("ContentBlockID")
           .ToTable("MediaItemContentBlock"));

            modelBuilder.Entity<Media>().HasMany(c => c.Tags).WithMany(i => i.MediaItems)
           .Map(t => t.MapLeftKey("MediaItemID")
           .MapRightKey("TagID")
           .ToTable("MediaItemTag"));

            /*modelBuilder.Entity<Page>().HasMany(c => c.ContentBlocks).WithMany(i => i.Pages)
           .Map(t => t.MapLeftKey("PageID")
           .MapRightKey("ContentBlockID")
           .ToTable("PageContentBlock"));*/
        }
    }
}