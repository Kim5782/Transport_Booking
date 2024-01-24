namespace Transport_Booking.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? PaymentMethod { get; set; }
        public virtual TransportBooking? TransportBooking { get; set; }

    }
}