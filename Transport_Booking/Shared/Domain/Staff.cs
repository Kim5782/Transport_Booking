using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Booking.Shared.Domain
{
    public class Staff: BaseDomainModel
    {
        public int StaffID { get; set; }
        public string? StaffName { get; set; }

        public string? StaffPosition { get; set; }

        public string? StaffContact { get; set; }


    }
}
