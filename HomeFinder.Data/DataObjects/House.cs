using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeFinder.Data.DataObjects
{
    public class House
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "int")]
        public long HouseId { get; set; }

        [ForeignKey("SellerId")]
        public long SellerId { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string Province { get; set; }

        public string Country { get; set; }

        public HouseType HouseType { get; set; }

        public string Description { get; set; }

        public int Area { get; set; }

        public string Amenities { get; set; }

        public string Parking { get; set; }

        public string Garage { get; set; }

        public int BedRooms { get; set; }

        public int BathRooms { get; set; }

        public string BackYard { get; set; }

        public string FrontYard { get; set; }

        public string Storage { get; set; }

        public string Laundry { get; set; }

        public string NeighborLocations { get; set; }

        public string Furniture { get; set; }

        public string Appliances { get; set; }

        public string Price { get; set; }

        [Timestamp]
        public DateTime TimeStamp { get; set; }

        public IList<HouseProspect> HouseProspects { get; set; }

        public IList<Comment> Comments { get; set; }

        public Seller Seller { get; set; }

    }
}
