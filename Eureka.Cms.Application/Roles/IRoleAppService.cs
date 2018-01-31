using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Eureka.Cms.Roles.Dto;

namespace Eureka.Cms.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
