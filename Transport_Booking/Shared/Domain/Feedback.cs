namespace Transport_Booking.Shared.Domain
{
    public class Feedback: BaseDomainModel
    {
        public int FeedbackId { get; set; }
        public string? Comments { get; set; }
        public double Rating { get; set; }
        public int BookingId { get; set; }
        public virtual TransportBooking? TransportBookings { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}