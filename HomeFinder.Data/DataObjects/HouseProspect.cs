using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeFinder.Data.DataObjects
{
    public class HouseProspect
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long HouseProspectId { get; set; }

        [ForeignKey("HouseId")]
        public long HouseId { get; set; }

        [ForeignKey("BuyerId")]
        public long BuyerId { get; set; }

        [Timestamp]
        public DateTime TimeStamp { get; set; }

        public House House { get; set; }

        public Buyer Buyer { get; set; }
    }
}
