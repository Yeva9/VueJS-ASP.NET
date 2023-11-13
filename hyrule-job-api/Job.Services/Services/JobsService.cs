using Job.Core.DTO;
using Job.Core.Services;

namespace Job.Services.Services
{
    //TBD
    public class JobsService : IJobsService
    {
        public Task<int> CreateJob(JobDto job)
        {
            throw new NotImplementedException();
        }

        public Task<JobDto> DeleteJob(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<JobDto>> DeleteJobs(int[] ids)
        {
            throw new NotImplementedException();
        }

        public Task<List<JobDto>> GetAllJobs()
        {
            throw new NotImplementedException();
        }

        public Task<JobDto> GetJob(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateJob(int id, JobDto job)
        {
            throw new NotImplementedException();
        }
    }
}