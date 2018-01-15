using System.Threading.Tasks;
using Abp.Application.Services;
using EWeb.Sessions.Dto;

namespace EWeb.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
