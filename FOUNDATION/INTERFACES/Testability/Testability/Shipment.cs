using System;

namespace Testability
{
    public class Shipment
    {
        public int Id { get; set; }
        public DateTime ShippingDate { get; set; }

        public Shipment(int id, DateTime shippingDate)
        {
            this.Id = id;
            this.ShippingDate = shippingDate;
        }


    }
}