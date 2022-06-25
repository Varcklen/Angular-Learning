using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Online_Book_Store_Web.Models
{
    public partial class OnlineBookStore2Context : DbContext
    {
        public OnlineBookStore2Context()
        {
        }

        public OnlineBookStore2Context(DbContextOptions<OnlineBookStore2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookAndBookAuthor> BookAndBookAuthor { get; set; }
        public virtual DbSet<BookAuthor> BookAuthor { get; set; }
        public virtual DbSet<BookOrder> BookOrder { get; set; }
        public virtual DbSet<Publishers> Publishers { get; set; }
        public virtual DbSet<StoreUser> StoreUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Online Book Store2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasIndex(e => e.PublisherId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.PublisherId);
            });

            modelBuilder.Entity<BookAndBookAuthor>(entity =>
            {
                entity.HasKey(e => new { e.BookId, e.AuthorId });

                entity.HasIndex(e => e.AuthorId);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.BookAndBookAuthor)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_BookAndBookAuthor_BookAuthor");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookAndBookAuthor)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_BookAndBookAuthor_Book");
            });

            modelBuilder.Entity<BookAuthor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BookOrder>(entity =>
            {
                entity.HasIndex(e => e.BookId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ByingDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookOrder)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_BookOrder_BookId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BookOrder)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_BookOrder_UserId");
            });

            modelBuilder.Entity<Publishers>(entity =>
            {
                entity.Property(e => e.City).IsRequired();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<StoreUser>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("UC_StoreUser_Email")
                    .IsUnique();

                entity.HasIndex(e => e.Login)
                    .HasName("UC_StoreUser_Login")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
