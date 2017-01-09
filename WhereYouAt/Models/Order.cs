using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WhereYouAt.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm tt}")]
        public DateTime ArriveTime { get; set; }
        public string DeliveryItem1 { get; set; }
        public int? DeliveryItem1Serial { get; set; }
        public string DeliveryItem2 { get; set; }
        public int? DeliveryItem2Serial { get; set; }
        public string DeliveryItem3 { get; set; }
        public int? DeliveryItem3Serial { get; set; }
        public string DeliveryItem4 { get; set; }
        public int? DeliveryItem4Serial { get; set; }
        public string DeliveryNotes { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm tt}")]
        public DateTime? DepartTime { get; set; }
    }
        public class OrderDBContext : DbContext
        {
            public DbSet<Order> Orders { get; set; }
        }
}