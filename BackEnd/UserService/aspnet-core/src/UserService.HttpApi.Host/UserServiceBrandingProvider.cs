using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace UserService;

[Dependency(ReplaceServices = true)]
public class UserServiceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "UserService";
}
