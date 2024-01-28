﻿using System;
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
    public class PaymentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PaymentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Payments
        [HttpGet]
        public async Task<IActionResult> GetPayments()
        {
            //return await _context.Payments.ToListAsync();
            var Payments = await _unitOfWork.Payments.GetAll(includes: q => q.Include(x => x.TransportBookings));
            return Ok(Payments);
        }

        // GET: api/Payments/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPayment(int id)
        {
            var Payment = await _unitOfWork.Payments.Get(q => q.Id == id);

            if (Payment == null)
            {
                return NotFound();
            }

            return Ok(Payment);
        }

        // PUT: api/Payments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayment(int id, Payment Payment)
        {
            if (id != Payment.Id)
            {
                return BadRequest();
            }

            // _context.Entry(Payment).State = EntityState.Modified;
            _unitOfWork.Payments.Update(Payment);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await PaymentExists(id))
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

        // POST: api/Payments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Payment>> PostPayment(Payment Payment)
        {
            await _unitOfWork.Payments.Insert(Payment);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPayment", new { id = Payment.Id }, Payment);
        }

        // DELETE: api/Payments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayment(int id)
        {
            var Payment = await _unitOfWork.Payments.Get(q => q.Id == id);
            if (Payment == null)
            {
                return NotFound();
            }

            await _unitOfWork.Payments.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> PaymentExists(int id)
        {
            var Payment = await _unitOfWork.Payments.Get(q => q.Id == id);
            return Payment != null;
        }
    }
}
