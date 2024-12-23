using Interloop.LoopQuality.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Interloop.LoopQuality.Permissions;

public class LoopQualityPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(LoopQualityPermissions.GroupName);

        myGroup.AddPermission(LoopQualityPermissions.Dashboard.Host, L("Permission:Dashboard"), MultiTenancySides.Host);
        myGroup.AddPermission(LoopQualityPermissions.Dashboard.Tenant, L("Permission:Dashboard"), MultiTenancySides.Tenant);

        var booksPermission = myGroup.AddPermission(LoopQualityPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(LoopQualityPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(LoopQualityPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(LoopQualityPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(LoopQualityPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LoopQualityResource>(name);
    }
}
