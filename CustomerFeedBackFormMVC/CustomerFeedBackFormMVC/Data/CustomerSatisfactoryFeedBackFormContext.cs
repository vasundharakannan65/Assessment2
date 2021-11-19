using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CustomerFeedBackFormMVC.Models;

#nullable disable

namespace CustomerFeedBackFormMVC.Data
{
    public partial class CustomerSatisfactoryFeedBackFormContext : DbContext
    {
        public CustomerSatisfactoryFeedBackFormContext()
        {
        }

        public CustomerSatisfactoryFeedBackFormContext(DbContextOptions<CustomerSatisfactoryFeedBackFormContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<UserInfo> UserInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=Trainee-06;Database=CustomerSatisfactoryFeedBackForm;User Id=SA;Password=MyPassword123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.Property(e => e.FeedbackId).HasComputedColumnSql("('GS'+right(format(getdate(),'yyyy')+CONVERT([varchar](8),[Id]),(8)))", false);

                entity.Property(e => e.FileUpload).IsUnicode(false);

                entity.Property(e => e.Information).IsUnicode(false);

                entity.Property(e => e.ReasonForUnsatisfactory).IsUnicode(false);

                entity.HasOne(d => d.Review)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.ReviewId)
                    .HasConstraintName("FK__Feedback__Review__412EB0B6");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Product__Categor__267ABA7A");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Review__ProductI__2E1BDC42");

                entity.HasOne(d => d.Rating)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.RatingId)
                    .HasConstraintName("FK__Review__RatingId__2F10007B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Review__UserId__2D27B809");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.EmailId).IsUnicode(false);

                entity.Property(e => e.Initials).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Region).IsUnicode(false);

                entity.Property(e => e.StreetAddress1).IsUnicode(false);

                entity.Property(e => e.StreetAddress2).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);

                entity.Property(e => e.ZipCode).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
