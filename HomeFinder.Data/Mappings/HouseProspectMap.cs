using HomeFinder.Data.DataObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeFinder.Data.Mappings
{
    public class HouseProspectMap : IEntityTypeConfiguration<HouseProspect>
    {
        public void Configure(EntityTypeBuilder<HouseProspect> builder)
        {
            builder.HasKey(x => new { x.HouseProspectId, x.HouseId,x.BuyerId});

            builder.HasOne(pt => pt.House)
        .WithMany(p => p.HouseProspects)
        .HasForeignKey(pt => pt.HouseId);

            builder.HasOne(pt => pt.Buyer)
        .WithMany(p => p.HouseProspects)
        .HasForeignKey(pt => pt.BuyerId);
        }
    }
}
