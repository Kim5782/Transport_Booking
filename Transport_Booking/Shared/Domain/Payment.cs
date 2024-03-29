﻿namespace Transport_Booking.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        public double? Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? PaymentMethod { get; set; }

        public int TransportBookingsId { get; set; }
        public virtual TransportBooking? TransportBookings { get; set; }

    }
}