using Volo.Abp.Settings;

namespace Interloop.LoopQuality.Settings;

public class LoopQualitySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LoopQualitySettings.MySetting1));
    }
}
