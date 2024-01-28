using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Transport_Booking.Shared.Domain;

namespace Transport_Booking.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Pan Rem",
                    Email = "panrem@gmail.com",
                    ContactNo = "88744323"
                },
                new Customer
                {
                    Id = 2,
                    Name = "Kim Lee",
                    Email = "kimchi@gmail.com",
                    ContactNo = "9653421"
                }
                );
        }
    }
}
