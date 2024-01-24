using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Transport_Booking.Server.Configurations.Entities;
using Transport_Booking.Server.Models;
using Transport_Booking.Shared.Domain;

namespace Transport_Booking.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<TransportBooking> TransportBookings { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new VehicleSeedConfiguration());
            builder.ApplyConfiguration(new StaffSeedConfiguration());
        }
    }
}