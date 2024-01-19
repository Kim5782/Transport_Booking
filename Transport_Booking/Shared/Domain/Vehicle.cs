using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Booking.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public string? PlateNumber { get; set; }
        public int VehicleId { get; set; }
        public string? Colour { get; set; }
        public string? Type { get; set; }
        public string? Model { get; set; }
        public int Capacity { get; set; }
        public string? Brand { get; set; }

        public virtual List<TransportBooking>? TransportBookings { get; set; }

    }
}
