using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Eureka.Cms.MultiTenancy.Dto;

namespace Eureka.Cms.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
