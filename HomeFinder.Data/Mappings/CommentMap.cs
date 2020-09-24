using HomeFinder.Data.DataObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeFinder.Data.Mappings
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => new { x.CommentId, x.HouseId, x.BuyerId });
           
            builder.Property(x => x.UserComment)
                    .HasMaxLength(200);
            builder.Property(x => x.IsItAReply)
                .HasMaxLength(200);
            builder.Property(x => x.TimeStamp);

            builder.HasOne(pt => pt.House)
            .WithMany(p => p.Comments)
            .HasForeignKey(pt => pt.HouseId).IsRequired();

            builder.HasOne(pt => pt.Buyer)
            .WithMany(p => p.Comments)
            .HasForeignKey(pt => pt.BuyerId).IsRequired();

        }
    }
}
