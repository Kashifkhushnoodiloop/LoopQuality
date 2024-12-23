using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using Interloop.LoopQuality.Localization;

namespace Interloop.LoopQuality.Web;

[Dependency(ReplaceServices = true)]
public class LoopQualityBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<LoopQualityResource> _localizer;

    public LoopQualityBrandingProvider(IStringLocalizer<LoopQualityResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
