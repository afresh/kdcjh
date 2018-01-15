using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EWeb.MultiTenancy.Dto;

namespace EWeb.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
