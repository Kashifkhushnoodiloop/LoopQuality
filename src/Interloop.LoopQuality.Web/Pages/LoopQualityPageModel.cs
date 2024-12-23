using Interloop.LoopQuality.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Interloop.LoopQuality.Web.Pages;

public abstract class LoopQualityPageModel : AbpPageModel
{
    protected LoopQualityPageModel()
    {
        LocalizationResourceType = typeof(LoopQualityResource);
    }
}
