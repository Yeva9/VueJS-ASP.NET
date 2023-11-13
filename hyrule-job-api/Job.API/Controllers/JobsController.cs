using AutoMapper;
using Job.Core.DTO;
using Job.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Job.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly JobContext _context;
        private readonly IMapper _mapper;

        public JobsController(
            JobContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<ActionResult> GetAllJobs()
        {
            return Ok(await _context.Jobs.ToArrayAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetJob(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            if (job == null)
            {
                return NotFound();
            }
            return Ok(job);
        }

        [HttpPost]
        public async Task<ActionResult<JobDto>> PostJob(JobDto job)
        {
            /*
            if (!ModelState.IsValid) {
                return BadRequest();
            }
            */
            var jobModel = _mapper.Map<JobDto, Core.Models.Job>(job);
            _context.Jobs.Add(jobModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                "PostJob",
                new { id = job.Id },
                job);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutJob(int id, JobDto job)
        {
            if (id != job.Id)
            {
                return BadRequest();
            }

            _context.Entry(job).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Jobs.Any(p => p.Id == id))
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

        [HttpDelete("{id}")]
        public async Task<ActionResult<Core.Models.Job>> DeleteJob(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            if (job == null)
            {
                return NotFound();
            }

            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();

            return job;
        }

        [HttpPost]
        [Route("Delete")]
        public async Task<ActionResult> DeleteMultiple([FromQuery] int[] ids)
        {
            var jobs = new List<Core.Models.Job>();
            foreach (var id in ids)
            {
                var job = await _context.Jobs.FindAsync(id);

                if (job == null)
                {
                    return NotFound();
                }

                jobs.Add(job);
            }

            _context.Jobs.RemoveRange(jobs);
            await _context.SaveChangesAsync();

            return Ok(jobs);
        }
    }
}
