using Microsoft.AspNetCore.Mvc;
using MyTrendApp.Models;
using MyTrendApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTrendApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbacksController : ControllerBase
    {
        private readonly FeedbackUsuarioService _feedbackUsuarioService;

        public FeedbacksController(FeedbackUsuarioService feedbackUsuarioService)
        {
            _feedbackUsuarioService = feedbackUsuarioService;
        }

        // GET: api/feedbacks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FeedbackUsuario>>> GetFeedbacks()
        {
            var feedbacks = await _feedbackUsuarioService.GetAllFeedbacksAsync();
            return Ok(feedbacks);
        }

        // GET: api/feedbacks/{IdFeedbackUsuario}
        [HttpGet("{IdFeedbackUsuario}")]
        public async Task<ActionResult<FeedbackUsuario>> GetFeedback(int IdFeedbackUsuario)
        {
            var feedback = await _feedbackUsuarioService.GetFeedbackByIdAsync(IdFeedbackUsuario);
            if (feedback == null)
            {
                return NotFound();
            }
            return Ok(feedback);
        }

        // POST: api/feedbacks
        [HttpPost]
        public async Task<ActionResult<FeedbackUsuario>> PostFeedback(FeedbackUsuario feedback)
        {
            var createdFeedback = await _feedbackUsuarioService.CreateFeedbackAsync(feedback);
            return CreatedAtAction(nameof(GetFeedback), new { IdFeedbackUsuario = createdFeedback.IdFeedbackUsuario }, createdFeedback);
        }

        // PUT: api/feedbacks/{IdFeedbackUsuario}
        [HttpPut("{IdFeedbackUsuario}")]
        public async Task<IActionResult> PutFeedback(int IdFeedbackUsuario, FeedbackUsuario feedback)
        {
            if (IdFeedbackUsuario != feedback.IdFeedbackUsuario)
            {
                return BadRequest();
            }
            await _feedbackUsuarioService.UpdateFeedbackAsync(feedback);
            return NoContent();
        }

        // DELETE: api/feedbacks/{IdFeedbackUsuario}
        [HttpDelete("{IdFeedbackUsuario}")]
        public async Task<IActionResult> DeleteFeedback(int IdFeedbackUsuario)
        {
            var exists = await _feedbackUsuarioService.DeleteFeedbackAsync(IdFeedbackUsuario);
            if (!exists)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
