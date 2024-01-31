using System.ComponentModel.DataAnnotations;

namespace Transport_Booking.Shared.Domain
{
    public class Staff : BaseDomainModel
    {

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Staff Name does not meet the requirements.")]
        public string? StaffName { get; set; }


        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Staff position does not meet the requirements.")]
        public string? StaffPosition { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? StaffContact { get; set; }

    }
}