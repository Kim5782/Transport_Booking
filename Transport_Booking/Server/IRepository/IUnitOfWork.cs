using System.Drawing;
using Transport_Booking.Shared.Domain;

namespace Transport_Booking.Server.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Payment> Payments { get; }
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Vehicle> Vehicles { get; }
        IGenericRepository<Feedback> Feedbacks { get; }
        IGenericRepository<TransportBooking> TransportBookings { get; }
        IGenericRepository<Customer> Customers { get; }
    }
}
