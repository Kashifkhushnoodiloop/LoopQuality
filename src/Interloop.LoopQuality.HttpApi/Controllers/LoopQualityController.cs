using Interloop.LoopQuality.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Interloop.LoopQuality.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LoopQualityController : AbpControllerBase
{
    protected LoopQualityController()
    {
        LocalizationResource = typeof(LoopQualityResource);
    }
}
