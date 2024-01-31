using System.ComponentModel.DataAnnotations;

namespace Transport_Booking.Shared.Domain
{
    public class Feedback : BaseDomainModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "Feedback Characters Exceed 500 Word Limit")]
        public string? Comments { get; set; }
        public double Rating { get; set; }
        public int TransportBookingsId { get; set; }
        public virtual TransportBooking? TransportBookings { get; set; }
    }
}
