namespace Transport_Booking.Shared.Domain
{
    public class TransportBooking : BaseDomainModel
    {
        public virtual Customer? Customer { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
        public virtual Staff? Staff { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string? PickupLocation { get; set; }
        public string? DropOffLocation { get; set; }
    }
}