using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EWeb.Roles.Dto;
using EWeb.Users.Dto;

namespace EWeb.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}