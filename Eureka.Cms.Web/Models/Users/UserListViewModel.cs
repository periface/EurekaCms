using System.Collections.Generic;
using Eureka.Cms.Roles.Dto;
using Eureka.Cms.Users.Dto;

namespace Eureka.Cms.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}