using HomeFinder.Data.DataObjects;
using HomeFinder.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace HomeFinder.Data
{
    public class HouseDBContext: DbContext,IHouseDBContext
    {
        public HouseDBContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Buyer> Buyers { get; set; }

        public DbSet<Seller> Sellers { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<HouseProspect> HouseProspects { get; set; }
        public DbSet<Comment> Comments { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-FVL63VH\MSSQLSERVER01;Database=HouseDB;Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration<Seller>(new SellerMap());
            builder.ApplyConfiguration<Buyer>(new BuyerMap());
            builder.ApplyConfiguration<House>(new HouseMap());
            builder.ApplyConfiguration<Comment>(new CommentMap());
            builder.ApplyConfiguration<HouseProspect>(new HouseProspectMap());

            


        }
    }
}
