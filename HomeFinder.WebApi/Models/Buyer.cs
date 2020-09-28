using System;
using System.Collections.Generic;

namespace HomeFinder.WebApi.Models
{
    public class Buyer
    {
        
        public long BuyerId { get; set; }

        public string FirstName { get; set; }
                
        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        
        public DateTime TimeStamp { get; set; }

        public IList<HouseProspect> HouseProspects { get; set; }

        public IList<Comment> Comments { get; set; }
    }
}
