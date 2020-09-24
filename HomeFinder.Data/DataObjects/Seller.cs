using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeFinder.Data.DataObjects
{
    public class Seller
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SellerId { get; set; }

        public string FirstName { get; set; }
        
        [ConcurrencyCheck]
        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; } 

        public string FaxNumber { get; set; }

        [Timestamp]
        public DateTime TimeStamp { get; set; }

        public IList <House> Houses { get; set; }
        
    }
}
