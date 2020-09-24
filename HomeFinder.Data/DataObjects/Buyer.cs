using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeFinder.Data.DataObjects
{
    public class Buyer
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long BuyerId { get; set; }

        public string FirstName { get; set; }

        [ConcurrencyCheck]
        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        
        [Timestamp]
        public DateTime TimeStamp { get; set; }

        public IList<HouseProspect> HouseProspects { get; set; }

        public IList<Comment> Comments { get; set; }
    }
}
