namespace Transport_Booking.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public int MakeId { get; set; }
        public string? ContactNo { get; set; }
        public string? Name { get; set; }

        public virtual List<TransportBooking>? TransportBookings { get; set; }

    }
}