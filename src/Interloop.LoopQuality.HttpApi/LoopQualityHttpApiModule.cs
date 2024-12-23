﻿using Localization.Resources.AbpUi;
using Interloop.LoopQuality.Localization;
using Volo.Abp.Account;
using Volo.Abp.SettingManagement;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.Localization;
using Volo.Abp.AuditLogging;
using Volo.Abp.LanguageManagement;
using Volo.FileManagement;
using Volo.Saas.Host;
using Volo.Abp.TextTemplateManagement;
using Volo.Abp.Gdpr;
using Volo.Abp.OpenIddict;
using Volo.Chat;

namespace Interloop.LoopQuality;

 [DependsOn(
    typeof(LoopQualityApplicationContractsModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpAccountAdminHttpApiModule),
    typeof(TextTemplateManagementHttpApiModule),
    typeof(AbpAuditLoggingHttpApiModule),
    typeof(AbpOpenIddictProHttpApiModule),
    typeof(LanguageManagementHttpApiModule),
    typeof(FileManagementHttpApiModule),
    typeof(SaasHostHttpApiModule),
    typeof(AbpGdprHttpApiModule),
    typeof(ChatHttpApiModule),
    typeof(AbpAccountPublicHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule)
    )]
public class LoopQualityHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<LoopQualityResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}