namespace Transport_Booking.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? ContactNo { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        //public virtual Payment? Payment { get; set; }
        public virtual List<TransportBooking>? TransportBookings { get; set; }
    }
}