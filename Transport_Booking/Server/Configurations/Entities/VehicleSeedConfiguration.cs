using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Transport_Booking.Shared.Domain;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Transport_Booking.Server.Configurations.Entities
{
    public class VehicleSeedConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasData(
                new Vehicle
                {
                    Id = 1,
                    PlateNumber = "SXT0123B",
                    VehicleId = 1,
                    Colour = "White",
                    Type = "Limousine",
                    Model = "Chrysler 300 Limo",
                    Capacity = 8,
                    Brand = "Chrysler"
                },
                new Vehicle
                {
                    Id = 2,
                    PlateNumber = "SSG0810F",
                    VehicleId = 2,
                    Colour = "Black",
                    Type = "Car",
                    Model = "S500L 4MATIC AMG Line Premium Plus (A)",
                    Capacity = 5,
                    Brand = "Mercedes-Benz"
                }
                ) ;
        }
    }
}
