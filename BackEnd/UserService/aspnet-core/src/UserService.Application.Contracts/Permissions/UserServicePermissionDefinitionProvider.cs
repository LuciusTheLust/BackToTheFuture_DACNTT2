using UserService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace UserService.Permissions;

public class UserServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(UserServicePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(UserServicePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<UserServiceResource>(name);
    }
}
