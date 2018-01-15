using Abp.Authorization;
using EWeb.Authorization.Roles;
using EWeb.Authorization.Users;

namespace EWeb.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
