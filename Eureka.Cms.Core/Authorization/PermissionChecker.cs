using Abp.Authorization;
using Eureka.Cms.Authorization.Roles;
using Eureka.Cms.Authorization.Users;

namespace Eureka.Cms.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
