using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using EWeb.Configuration.Dto;

namespace EWeb.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EWebAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
