using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Transport_Booking.Shared.Domain;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Transport_Booking.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    StaffName = "Peter Tan",
                    StaffPosition = "Driver",
                    StaffContact = "90223457"
                },
                new Staff
                {
                    Id = 2,
                    StaffName = "Jansen Teo",
                    StaffPosition = "Booking Manager",
                    StaffContact = "89259981"
                },
                new Staff
                {
                    Id = 3,
                    StaffName = "Timothy Yap",
                    StaffPosition = "Driver",
                    StaffContact = "94339800"
                }
                ); 
        }
    }
}
