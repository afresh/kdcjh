using System.Threading.Tasks;
using Abp.Application.Services;
using EWeb.Authorization.Accounts.Dto;

namespace EWeb.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
