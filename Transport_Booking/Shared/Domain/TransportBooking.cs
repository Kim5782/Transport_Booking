namespace Transport_Booking.Shared.Domain
{
    public class TransportBooking : BaseDomainModel
    {
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        public int VehicleId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }

        public int StaffId { get; set; }
        public virtual Staff? Staff { get; set; }

        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        //public DateTime Time { get; set; }
        public string? PickupLocation { get; set; }
        public string? DropOffLocation { get; set; }
    }
}