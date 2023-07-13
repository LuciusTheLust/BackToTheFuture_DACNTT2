using Volo.Abp.Settings;

namespace UserService.Settings;

public class UserServiceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(UserServiceSettings.MySetting1));
    }
}
