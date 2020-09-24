using System;
using System.Collections.Generic;

namespace HomeFinder.Services.Domain
{
    public class Seller
    {
        
        public long SellerId { get; set; }

        public string FirstName { get; set; }
                
        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; } 

        public string FaxNumber { get; set; }
               
        public DateTime TimeStamp { get; set; }

        public IList <House> Houses { get; set; }
        
    }
}
