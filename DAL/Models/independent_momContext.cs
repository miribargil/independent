using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DAL.Models
{
    public partial class independent_momContext : DbContext
    {
        public independent_momContext()
        {
        }

        public independent_momContext(DbContextOptions<independent_momContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BeforeBirth> BeforeBirths { get; set; }
        public virtual DbSet<Development> Developments { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<KupotCholim> KupotCholims { get; set; }
        public virtual DbSet<PostnatalHotel> PostnatalHotels { get; set; }
        public virtual DbSet<Table1> Table1s { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server= COMP;Database= independent_mom;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<BeforeBirth>(entity =>
            {
                entity.HasKey(e => e.Week);

                entity.ToTable("before_birth");

                entity.Property(e => e.Week)
                    .HasMaxLength(10)
                    .HasColumnName("week")
                    .IsFixedLength(true);

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.Month)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("month")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Development>(entity =>
            {
                entity.HasKey(e => e.IdMonth);

                entity.ToTable("development");

                entity.Property(e => e.IdMonth)
                    .HasMaxLength(10)
                    .HasColumnName("id_month")
                    .IsFixedLength(true);

                entity.Property(e => e.ContentDev)
                    .IsRequired()
                    .HasColumnName("content_dev");
            });

            modelBuilder.Entity<Hospital>(entity =>
            {
                entity.HasKey(e => e.IdHospital);

                entity.ToTable("hospitals");

                entity.Property(e => e.IdHospital)
                    .HasMaxLength(10)
                    .HasColumnName("id_hospital")
                    .IsFixedLength(true);

                entity.Property(e => e.ContentHospital)
                    .IsRequired()
                    .HasColumnName("content_hospital");

                entity.Property(e => e.LimkHospital)
                    .HasMaxLength(50)
                    .HasColumnName("limk_hospital");

                entity.Property(e => e.NameHospital)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("name_hospital")
                    .IsFixedLength(true);

                entity.Property(e => e.PhHospital)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ph_hospital")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<KupotCholim>(entity =>
            {
                entity.HasKey(e => e.IdKupa);

                entity.ToTable("kupot_cholim");

                entity.Property(e => e.IdKupa)
                    .HasMaxLength(10)
                    .HasColumnName("id_kupa")
                    .IsFixedLength(true);

                entity.Property(e => e.LinkKupa)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("link_kupa");

                entity.Property(e => e.NameKupa)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("name_kupa")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PostnatalHotel>(entity =>
            {
                entity.HasKey(e => e.IdHotel);

                entity.ToTable("postnatal_hotel");

                entity.Property(e => e.IdHotel)
                    .HasMaxLength(10)
                    .HasColumnName("id_hotel")
                    .IsFixedLength(true);

                entity.Property(e => e.ContentHotel)
                    .IsRequired()
                    .HasColumnName("content_hotel");

                entity.Property(e => e.LinkHotel)
                    .HasMaxLength(50)
                    .HasColumnName("link_hotel");

                entity.Property(e => e.NameHotel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("name_hotel")
                    .IsFixedLength(true);

                entity.Property(e => e.PhHotel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ph_hotel")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table1");

                entity.Property(e => e.Ss)
                    .HasMaxLength(10)
                    .HasColumnName("ss")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.NumMom);

                entity.ToTable("users");

                entity.HasIndex(e => e.IdKupa, "IX_users");

                entity.Property(e => e.NumMom)
                    .HasMaxLength(10)
                    .HasColumnName("num_mom")
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("f_name")
                    .IsFixedLength(true);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.IdKupa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("id_kupa")
                    .IsFixedLength(true);

                entity.Property(e => e.LName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("l_name")
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("password")
                    .IsFixedLength(true);

                entity.Property(e => e.PhNum)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("ph_num")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdKupaNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdKupa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_users_kupot_cholim");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
