using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Eureka.Cms.Roles.Dto;
using Eureka.Cms.Users.Dto;

namespace Eureka.Cms.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}