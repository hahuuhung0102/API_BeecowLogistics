using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BeecowLogistics.Services.Entities
{
    public partial class BeecowLogisticContext : DbContext
    {
        public BeecowLogisticContext()
        {
        }

        public BeecowLogisticContext(DbContextOptions<BeecowLogisticContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChildRoute> ChildRoutes { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PackageType> PackageTypes { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<ShippingFee> ShippingFees { get; set; }
        public virtual DbSet<ShippingFeeDetail> ShippingFeeDetails { get; set; }
        public virtual DbSet<SpecialOption> SpecialOptions { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<StationType> StationTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<VehicleRoute> VehicleRoutes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChildRoute>(entity =>
            {
                entity.ToTable("ChildRoute");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.TimeEnd).HasColumnType("datetime");

                entity.Property(e => e.TimeStart).HasColumnType("datetime");
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.ToTable("Delivery");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Codamount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CODAmount");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Codfee)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CODFee");

                entity.Property(e => e.CurrentPosition).HasMaxLength(255);

                entity.Property(e => e.DeliveryId).HasColumnName("DeliveryID");

                entity.Property(e => e.IsCod).HasColumnName("IsCOD");

                entity.Property(e => e.PackageTypeId).HasColumnName("PackageTypeID");

                entity.Property(e => e.PayBy).HasMaxLength(255);

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.ReceiverCity).HasMaxLength(255);

                entity.Property(e => e.ReceiverDistrict).HasMaxLength(255);

                entity.Property(e => e.ReceiverName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ReceiverPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverStreet).HasMaxLength(255);

                entity.Property(e => e.ReceiverWard).HasMaxLength(255);

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.SenderCity).HasMaxLength(255);

                entity.Property(e => e.SenderDistrict).HasMaxLength(255);

                entity.Property(e => e.SenderName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SenderPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SenderStreet).HasMaxLength(255);

                entity.Property(e => e.SenderWard).HasMaxLength(255);

                entity.Property(e => e.ShippingFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SpecialOptionId).HasColumnName("SpecialOptionID");

                entity.Property(e => e.StationForRentId).HasColumnName("StationForRentID");

                entity.Property(e => e.StationId).HasColumnName("StationID");

                entity.Property(e => e.Tax).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Delivery)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.DeliveryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Delivery");

                entity.HasOne(d => d.PackageType)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PackageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_PackageType");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_PaymentType");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Route");

                entity.HasOne(d => d.SpecialOption)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.SpecialOptionId)
                    .HasConstraintName("FK_Order_SpecialOption");

                entity.HasOne(d => d.StationForRent)
                    .WithMany(p => p.OrderStationForRents)
                    .HasForeignKey(d => d.StationForRentId)
                    .HasConstraintName("FK_Order_Station1");

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.OrderStations)
                    .HasForeignKey(d => d.StationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Station");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Order_User");
            });

            modelBuilder.Entity<PackageType>(entity =>
            {
                entity.ToTable("PackageType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.ToTable("PaymentType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.ToTable("Route");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RouteName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Routing).IsRequired();

                entity.Property(e => e.ShippingFeeId).HasColumnName("ShippingFeeID");

                entity.Property(e => e.TimeEnd).HasColumnType("datetime");

                entity.Property(e => e.TimeStart).HasColumnType("datetime");

                entity.HasOne(d => d.ShippingFee)
                    .WithMany(p => p.Routes)
                    .HasForeignKey(d => d.ShippingFeeId)
                    .HasConstraintName("FK_Route_ShippingFee");
            });

            modelBuilder.Entity<ShippingFee>(entity =>
            {
                entity.ToTable("ShippingFee");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ShippingFeeDetail>(entity =>
            {
                entity.ToTable("ShippingFeeDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ShippingFeeId).HasColumnName("ShippingFeeID");

                entity.Property(e => e.UnitPrice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ShippingFee)
                    .WithMany(p => p.ShippingFeeDetails)
                    .HasForeignKey(d => d.ShippingFeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShippingFeeDetail_ShippingFee");
            });

            modelBuilder.Entity<SpecialOption>(entity =>
            {
                entity.ToTable("SpecialOption");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Station>(entity =>
            {
                entity.ToTable("Station");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.District).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationTypeId).HasColumnName("StationTypeID");

                entity.Property(e => e.Ward).HasMaxLength(255);

                entity.HasOne(d => d.StationType)
                    .WithMany(p => p.Stations)
                    .HasForeignKey(d => d.StationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Station_StationType");
            });

            modelBuilder.Entity<StationType>(entity =>
            {
                entity.ToTable("StationType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasIndex(e => e.Phone, "UQ__Users__5C7E359E8161FDC9")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PasswordHash).IsRequired();

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK_User_UserType");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("UserType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.ToTable("Vehicle");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.StationId).HasColumnName("StationID");

                entity.Property(e => e.Type).HasMaxLength(255);

                entity.Property(e => e.WorkingDays).HasMaxLength(50);

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.StationId)
                    .HasConstraintName("FK_Vehicle_Station");
            });

            modelBuilder.Entity<VehicleRoute>(entity =>
            {
                entity.ToTable("VehicleRoute");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.VehicleRoutes)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleRoute_Route");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehicleRoutes)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleRoute_Vehicle");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
