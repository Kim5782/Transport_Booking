namespace Transport_Booking.Shared.Domain
{
    public class Feedback : BaseDomainModel
    {
        public string? Comments { get; set; }
        public double Rating { get; set; }
        public virtual TransportBooking? TransportBookings { get; set; }
    }
}
