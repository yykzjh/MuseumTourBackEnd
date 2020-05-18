using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MuseumTourBackEnd.Models
{
    public partial class MuseumContext : DbContext
    {
        public MuseumContext()
        {
        }

        public MuseumContext(DbContextOptions<MuseumContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Collection> Collection { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<EfmigrationsHistory> EfmigrationsHistory { get; set; }
        public virtual DbSet<Exhibition> Exhibition { get; set; }
        public virtual DbSet<Maintable> Maintable { get; set; }
        public virtual DbSet<MuseumInformation> MuseumInformation { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<User> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Username })
                    .HasName("PRIMARY");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Roles)
                    .HasColumnName("roles")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Collection>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PRIMARY");

                entity.Property(e => e.Oid)
                    .HasColumnName("oid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Midex)
                    .HasColumnName("midex")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ointro).HasColumnName("ointro");

                entity.Property(e => e.Oname)
                    .IsRequired()
                    .HasColumnName("oname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ophoto).HasColumnName("ophoto");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasKey(e => new { e.Midex, e.Userid })
                    .HasName("PRIMARY");

                entity.Property(e => e.Midex)
                    .HasColumnName("midex")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Envscore)
                    .HasColumnName("envscore")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Exhscore)
                    .HasColumnName("exhscore")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Msg)
                    .HasColumnName("msg")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'null'");

                entity.Property(e => e.Serscore)
                    .HasColumnName("serscore")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.HasKey(e => e.Aid)
                    .HasName("PRIMARY");

                entity.Property(e => e.Aid)
                    .HasColumnName("aid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mid)
                    .HasColumnName("mid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EfmigrationsHistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__EFMigrationsHistory");

                entity.Property(e => e.MigrationId)
                    .HasMaxLength(95)
                    .IsUnicode(false);

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Exhibition>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PRIMARY");

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Eintro).HasColumnName("eintro");

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasColumnName("ename")
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Midex)
                    .HasColumnName("midex")
                    .HasColumnType("int(150)");
            });

            modelBuilder.Entity<Maintable>(entity =>
            {
                entity.HasKey(e => e.Midex)
                    .HasName("PRIMARY");

                entity.ToTable("maintable");

                entity.Property(e => e.Midex)
                    .HasColumnName("midex")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mbase).HasColumnName("mbase");

                entity.Property(e => e.Mname)
                    .IsRequired()
                    .HasColumnName("mname")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MuseumInformation>(entity =>
            {
                entity.HasKey(e => e.Midex)
                    .HasName("PRIMARY");

                entity.ToTable("Museum_Information");

                entity.Property(e => e.Midex)
                    .HasColumnName("midex")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Maddress)
                    .IsRequired()
                    .HasColumnName("maddress")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Mbase)
                    .HasColumnName("mbase")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Mname)
                    .IsRequired()
                    .HasColumnName("mname")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Mopentime)
                    .IsRequired()
                    .HasColumnName("mopentime")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PictureAddress)
                    .HasColumnName("picture_address")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.Analyseresult).HasColumnType("longtext");

                entity.Property(e => e.Content).HasColumnType("longtext");

                entity.Property(e => e.Museum).HasColumnType("longtext");

                entity.Property(e => e.Publishtime).HasColumnType("longtext");

                entity.Property(e => e.Source).HasColumnType("longtext");

                entity.Property(e => e.Title).HasColumnType("longtext");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Coright)
                    .HasColumnName("coright")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Nickname)
                    .HasColumnName("nickname")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Userpwd)
                    .HasColumnName("userpwd")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
