using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CIS_420_Project.Models
{
    public partial class ORI_WEB_NEWContext : DbContext
    {
        public ORI_WEB_NEWContext()
        {
        }

        public ORI_WEB_NEWContext(DbContextOptions<ORI_WEB_NEWContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ORI_WEB_NEW");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articles>(entity =>
            {
                entity.HasKey(e => e.ArticleId)
                    .HasName("PK__articles__CC36F660B32A3300");

                entity.ToTable("articles");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleTitle)
                    .HasColumnName("article_title")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("expiration_date")
                    .HasColumnType("date");

                entity.Property(e => e.ImagePath)
                    .HasColumnName("image_path")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Files>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK__files__07D884C646013EF1");

                entity.ToTable("files");

                entity.Property(e => e.FileId)
                    .HasColumnName("file_id")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FileDesc)
                    .HasColumnName("file_desc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasColumnName("file_path")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("user_type");

                entity.Property(e => e.UserTypeId)
                    .HasColumnName("user_type_id")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeDesc)
                    .HasColumnName("user_type_desc")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__users__B9BE370FAE976624");

                entity.ToTable("users");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("email_address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Organization)
                    .HasColumnName("organization")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeId)
                    .HasColumnName("user_type_id")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.WebsiteUrl)
                    .HasColumnName("website_url")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK__users__user_type__29572725");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
