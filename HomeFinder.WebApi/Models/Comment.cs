using System;

namespace HomeFinder.WebApi.Models
{
    public class Comment
    {
       
        public long CommentId { get; set; }
              
        public long HouseId { get; set; }
                
        public long BuyerId { get; set; }

        public bool IsItAReply { get; set; }
                
        public DateTime TimeStamp { get; set; }

        public string UserComment { get; set; }

        public House House { get; set; }

        public Buyer Buyer { get; set; }

    }
}
