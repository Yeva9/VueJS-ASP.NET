using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Job.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        [HttpGet]
        public void GetJobs()
        {

        }
    }
}
