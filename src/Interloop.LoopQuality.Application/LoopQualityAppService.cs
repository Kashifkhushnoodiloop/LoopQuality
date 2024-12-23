using Interloop.LoopQuality.Localization;
using Volo.Abp.Application.Services;

namespace Interloop.LoopQuality;

/* Inherit your application services from this class.
 */
public abstract class LoopQualityAppService : ApplicationService
{
    protected LoopQualityAppService()
    {
        LocalizationResource = typeof(LoopQualityResource);
    }
}
