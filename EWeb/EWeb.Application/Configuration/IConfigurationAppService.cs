using System.Threading.Tasks;
using Abp.Application.Services;
using EWeb.Configuration.Dto;

namespace EWeb.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}