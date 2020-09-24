using HomeFinder.Data.DataObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeFinder.Data.Mappings
{
    public class HouseMap : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder.HasKey(x => x.HouseId);
            builder.Property(x => x.Address1)
                    .HasMaxLength(100);
            builder.Property(x => x.Address2)
                    .HasMaxLength(100);
            builder.Property(x => x.City)
                    .HasMaxLength(20);
            builder.Property(x => x.ZipCode)
                    .HasMaxLength(10);
            builder.Property(x => x.Province)
                    .HasMaxLength(10);
            builder.Property(x => x.Country)
                    .HasMaxLength(30);
            builder.Property(x => x.HouseType);
           
            builder.Property(x => x.Description)
                    .HasMaxLength(100);
            builder.Property(x => x.Amenities)
                   .HasMaxLength(200);
            builder.Property(x => x.Area);
            builder.Property(x => x.Parking)
                   .HasMaxLength(100);
            builder.Property(x => x.Garage)
                   .HasMaxLength(100);
            builder.Property(x => x.BedRooms);
            builder.Property(x => x.BathRooms);
            builder.Property(x => x.BackYard)
                   .HasMaxLength(100);
            builder.Property(x => x.FrontYard)
                   .HasMaxLength(100);
            builder.Property(x => x.Storage)
                   .HasMaxLength(100);
            builder.Property(x => x.Laundry)
                   .HasMaxLength(100);
            builder.Property(x => x.NeighborLocations)
                   .HasMaxLength(100);
            builder.Property(x => x.Furniture)
                   .HasMaxLength(100);
            builder.Property(x => x.Appliances)
                   .HasMaxLength(100);
            builder.Property(x => x.Price);

            builder.HasOne(pt => pt.Seller)
            .WithMany(p => p.Houses)
            .HasForeignKey(pt => pt.SellerId).IsRequired();

        }
    }
}
