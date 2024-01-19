namespace Transport_Booking.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public int CustomerId { get; set; }
        public string? ContactNo { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int BookingId { get; set; }
        public int FeedbackId { get; set; }
        public virtual Feedback? Feedback { get; set; }
        public virtual List<TransportBooking>? TransportBookings { get; set; }
        public virtual List<Feedback>? Feeback { get; set; }
    }
}