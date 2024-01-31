using System.ComponentModel.DataAnnotations;

namespace Transport_Booking.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? ContactNo { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet the requirements.")]
        public string? Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string? Email { get; set; }

        public virtual List<TransportBooking>? TransportBookings { get; set; }
    }
}