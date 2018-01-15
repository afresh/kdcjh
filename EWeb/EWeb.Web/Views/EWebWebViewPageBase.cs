using Abp.Web.Mvc.Views;

namespace EWeb.Web.Views
{
    public abstract class EWebWebViewPageBase : EWebWebViewPageBase<dynamic>
    {

    }

    public abstract class EWebWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected EWebWebViewPageBase()
        {
            LocalizationSourceName = EWebConsts.LocalizationSourceName;
        }
    }
}