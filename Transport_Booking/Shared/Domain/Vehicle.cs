using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Booking.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public string? LiscensePlateNumber { get; set; }
        public int MakeId { get; set; }
        public virtual VehicleModel? VehicleModel { get; set; }
        public virtual VehicleBrand? VehicleBrand { get; set; }

        public virtual List<TransportBooking>? TransportBookings { get; set; }

    }
}
