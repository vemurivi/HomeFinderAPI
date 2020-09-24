using HomeFinder.Data.DataObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeFinder.Data.Mappings
{
    public class SellerMap :IEntityTypeConfiguration<Seller>
    {

        public void Configure(EntityTypeBuilder<Seller> x)
        {
            
            x.HasKey(x => x.SellerId);
            x.Property(x => x.FirstName)
                .HasMaxLength(50);
            x.Property(x => x.LastName)
               .HasMaxLength(50);
            x.Property(y => y.Email)
                .HasMaxLength(50);
            x.Property(y => y.PhoneNumber)
                .HasMaxLength(15);
            x.Property(y => y.FaxNumber)
                .HasMaxLength(15);
            

        }
    }
}
