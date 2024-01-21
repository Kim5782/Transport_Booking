namespace Transport_Booking.Shared.Domain
{
    public class Driver : BaseDomainModel
    {
        public int DriverId { get; set; }

        public string? ContactNo { get; set; }

        public string? Name { get; set; }

        public int StaffId { get; set; }
        public virtual Staff? Staff { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
        public int BookingId { get; set; }
        public virtual List<TransportBooking>? TransportBookings { get; set; }
    }
}