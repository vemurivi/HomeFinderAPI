using HomeFinder.Data.DataObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeFinder.Data.Mappings
{
    public class BuyerMap : IEntityTypeConfiguration<Buyer>
    {
        public void Configure(EntityTypeBuilder<Buyer> builder)
        {
            builder.HasKey(x => x.BuyerId);
            builder.Property(x => x.FirstName)
                .HasMaxLength(50);
            builder.Property(x => x.LastName)
                .HasMaxLength(50);
            builder.Property(x => x.Email)
                .HasMaxLength(50);
            builder.Property(x => x.PhoneNumber)
                .HasMaxLength(50);
            

        }
    }
}
