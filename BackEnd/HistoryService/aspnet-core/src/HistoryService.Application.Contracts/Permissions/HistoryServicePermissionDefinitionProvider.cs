using HistoryService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HistoryService.Permissions;

public class HistoryServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HistoryServicePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(HistoryServicePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HistoryServiceResource>(name);
    }
}
