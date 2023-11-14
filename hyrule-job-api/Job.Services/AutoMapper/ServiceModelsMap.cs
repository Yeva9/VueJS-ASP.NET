using AutoMapper;
using Job.Core.DTO;

namespace Job.Services.AutoMapper
{
    public class ServiceModelsMap: Profile
    {
        public ServiceModelsMap()
        {
            CreateMap<JobDto, Core.Models.Job>();
            CreateMap<Core.Models.Job, JobDto>();
        }
    }
}
