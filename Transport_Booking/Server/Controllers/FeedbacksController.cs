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
    public class FeedbacksController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public FeedbacksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Feedbacks
        [HttpGet]
        public async Task<IActionResult> GetFeedbacks()
        {
            //return await _context.Feedbacks.ToListAsync();
            var Feedbacks = await _unitOfWork.Feedbacks.GetAll();
            return Ok(Feedbacks);
        }

        // GET: api/Feedbacks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeedback(int id)
        {
            var Feedback = await _unitOfWork.Feedbacks.Get(q => q.Id == id);

            if (Feedback == null)
            {
                return NotFound();
            }

            return Ok(Feedback);
        }

        // PUT: api/Feedbacks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFeedback(int id, Feedback Feedback)
        {
            if (id != Feedback.Id)
            {
                return BadRequest();
            }

            // _context.Entry(Feedback).State = EntityState.Modified;
            _unitOfWork.Feedbacks.Update(Feedback);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await FeedbackExists(id))
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

        // POST: api/Feedbacks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Feedback>> PostFeedback(Feedback Feedback)
        {
            await _unitOfWork.Feedbacks.Insert(Feedback);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetFeedback", new { id = Feedback.Id }, Feedback);
        }

        // DELETE: api/Feedbacks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeedback(int id)
        {
            var Feedback = await _unitOfWork.Feedbacks.Get(q => q.Id == id);
            if (Feedback == null)
            {
                return NotFound();
            }

            await _unitOfWork.Feedbacks.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> FeedbackExists(int id)
        {
            var Feedback = await _unitOfWork.Feedbacks.Get(q => q.Id == id);
            return Feedback != null;
        }
    }
}
