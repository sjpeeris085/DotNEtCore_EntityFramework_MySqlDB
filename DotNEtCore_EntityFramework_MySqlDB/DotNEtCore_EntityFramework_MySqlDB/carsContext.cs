using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DotNEtCore_EntityFramework_MySqlDB
{
    public partial class carsContext : DbContext
    {
        public carsContext()
        {
        }

        public carsContext(DbContextOptions<carsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Hire> Hires { get; set; }
        public virtual DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=cars;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.24-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admin");

                entity.Property(e => e.AdminId)
                    .HasColumnType("int(11)")
                    .HasColumnName("admin_id");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("pass");

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("uname");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("cars");

                entity.Property(e => e.CarId)
                    .HasColumnType("int(11)")
                    .HasColumnName("car_id");

                entity.Property(e => e.Capacity)
                    .HasColumnType("int(11)")
                    .HasColumnName("capacity");

                entity.Property(e => e.CarName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("car_name");

                entity.Property(e => e.CarType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("car_type");

                entity.Property(e => e.HireCost)
                    .HasColumnType("int(11)")
                    .HasColumnName("hire_cost");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("image");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.Property(e => e.ClientId)
                    .HasColumnType("int(11)")
                    .HasColumnName("client_id");

                entity.Property(e => e.CarId)
                    .HasColumnType("int(11)")
                    .HasColumnName("car_id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("fname");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("gender");

                entity.Property(e => e.IdNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_no");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("location");

                entity.Property(e => e.Mpesa)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("mpesa");

                entity.Property(e => e.Phone)
                    .HasColumnType("int(11)")
                    .HasColumnName("phone");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Hire>(entity =>
            {
                entity.ToTable("hire");

                entity.Property(e => e.HireId)
                    .HasColumnType("int(11)")
                    .HasColumnName("hire_id");

                entity.Property(e => e.CarId)
                    .HasColumnType("int(11)")
                    .HasColumnName("car_id");

                entity.Property(e => e.ClientId)
                    .HasColumnType("int(11)")
                    .HasColumnName("client_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasKey(e => e.MsgId)
                    .HasName("PRIMARY");

                entity.ToTable("message");

                entity.Property(e => e.MsgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("msg_id");

                entity.Property(e => e.ClientId)
                    .HasColumnType("int(11)")
                    .HasColumnName("client_id");

                entity.Property(e => e.Message1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("message");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
