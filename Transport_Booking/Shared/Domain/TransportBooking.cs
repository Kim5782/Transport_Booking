namespace Transport_Booking.Shared.Domain
{
    public class TransportBooking : BaseDomainModel
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
        public int DriverId { get; set; }
        public virtual Driver? Driver { get; set; }

        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string? PickupLocation { get; set; }
        public string? DropOffLocation { get; set; }

    }
}