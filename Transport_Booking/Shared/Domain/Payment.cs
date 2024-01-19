using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Booking.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        public int PaymentId { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? PaymentMethod { get; set; }
        public int BookingId { get; set; }
        public virtual TransportBooking? TransportBooking { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

    }
}
