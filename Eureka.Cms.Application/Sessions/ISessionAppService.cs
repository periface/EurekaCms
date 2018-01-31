using System.Threading.Tasks;
using Abp.Application.Services;
using Eureka.Cms.Sessions.Dto;

namespace Eureka.Cms.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
