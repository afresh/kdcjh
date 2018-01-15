using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EWeb.Roles.Dto;

namespace EWeb.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
