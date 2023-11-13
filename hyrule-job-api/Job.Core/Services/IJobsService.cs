using Job.Core.DTO;

namespace Job.Core.Services
{
    /// <summary>
    /// Jobs management
    /// </summary>
    public interface IJobsService
    {
        Task<List<JobDto>> GetAllJobs();
        Task<JobDto> GetJob(int id);
        Task<int> CreateJob(JobDto job);
        Task UpdateJob(int id, JobDto job);
        Task<JobDto> DeleteJob(int id);
        Task<List<JobDto>> DeleteJobs(int[] ids);
    }
}
