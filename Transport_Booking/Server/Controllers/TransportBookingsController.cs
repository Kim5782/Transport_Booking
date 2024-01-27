using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Transport_Booking.Server.Data;
using Transport_Booking.Server.IRepository;
using Transport_Booking.Server.Repository;
using Transport_Booking.Shared.Domain;

namespace Transport_Booking.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportBookingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TransportBookingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/TransportBookings
        [HttpGet]
        public async Task<IActionResult> GetTransportBookings()
        {
            //return await _context.TransportBookings.ToListAsync();
            var TransportBookings = await _unitOfWork.TransportBookings.GetAll(includes: q => q.Include(x => x.Customer).Include(x => x.Staff).Include(x => x.Vehicle));
            return Ok(TransportBookings);
        }

        // GET: api/TransportBookings/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTransportBooking(int id)
        {
            var TransportBooking = await _unitOfWork.TransportBookings.Get(q => q.Id == id);

            if (TransportBooking == null)
            {
                return NotFound();
            }

            return Ok(TransportBooking);
        }

        // PUT: api/TransportBookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransportBooking(int id, TransportBooking TransportBooking)
        {
            if (id != TransportBooking.Id)
            {
                return BadRequest();
            }

            // _context.Entry(TransportBooking).State = EntityState.Modified;
            _unitOfWork.TransportBookings.Update(TransportBooking);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await TransportBookingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TransportBookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TransportBooking>> PostTransportBooking(TransportBooking TransportBooking)
        {
            await _unitOfWork.TransportBookings.Insert(TransportBooking);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetTransportBooking", new { id = TransportBooking.Id }, TransportBooking);
        }

        // DELETE: api/TransportBookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransportBooking(int id)
        {
            var TransportBooking = await _unitOfWork.TransportBookings.Get(q => q.Id == id);
            if (TransportBooking == null)
            {
                return NotFound();
            }

            await _unitOfWork.TransportBookings.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> TransportBookingExists(int id)
        {
            var TransportBooking = await _unitOfWork.TransportBookings.Get(q => q.Id == id);
            return TransportBooking != null;
        }
    }
}
