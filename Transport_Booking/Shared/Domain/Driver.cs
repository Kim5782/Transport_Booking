namespace Transport_Booking.Shared.Domain
{
    public class Driver : BaseDomainModel
    {
        public int DriverId { get; set; }

        public string? ContactNo { get; set; }

        public string? Name { get; set; }

        public int StaffId { get; set; }
        public virtual Staff? Staff { get; set; }

        public virtual List<TransportBooking>? TransportBookings { get; set; }
    }
}