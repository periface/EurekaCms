using System.Collections.Generic;
using Eureka.Cms.Roles.Dto;

namespace Eureka.Cms.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}