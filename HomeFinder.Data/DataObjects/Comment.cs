using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeFinder.Data.DataObjects
{
    public class Comment
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CommentId { get; set; }

        [ForeignKey("HouseId")]
        public long HouseId { get; set; }

        [ForeignKey("BuyerId")]
        public long BuyerId { get; set; }

        public bool IsItAReply { get; set; }

        [Timestamp]
        public DateTime TimeStamp { get; set; }

        public string UserComment { get; set; }

        public House House { get; set; }

        public Buyer Buyer { get; set; }

    }
}
