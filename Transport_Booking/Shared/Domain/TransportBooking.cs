using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Transport_Booking.Shared.Domain
{
    public class TransportBooking : BaseDomainModel, IValidatableObject
    {
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        public int VehicleId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }

        public int StaffId { get; set; }
        public virtual Staff? Staff { get; set; }

        public DateTime DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        //public DateTime Time { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Pick up name location is too long.")]

        public string? PickupLocation { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Drop Off name location is too long.")]

        public string? DropOffLocation { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateOut != null)
            {
                if(DateOut < DateIn)
                {
                    yield return new ValidationResult("Date Out must be later than Date In", new[] { "DateOut" });
                }
            }
        }
    }
}