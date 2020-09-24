using System;

namespace HomeFinder.Services.Domain
{
    public class HouseProspect
    {
        public long HouseProspectId { get; set; }
                
        public long HouseId { get; set; }
                
        public long BuyerId { get; set; }
                
        public DateTime TimeStamp { get; set; }

        public House House { get; set; }

        public Buyer Buyer { get; set; }
    }
}
