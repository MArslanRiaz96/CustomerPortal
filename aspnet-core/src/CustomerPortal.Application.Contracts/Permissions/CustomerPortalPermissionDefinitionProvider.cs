using CustomerPortal.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CustomerPortal.Permissions;

public class CustomerPortalPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CustomerPortalPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CustomerPortalPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CustomerPortalResource>(name);
    }
}
