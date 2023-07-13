using Volo.Abp.Settings;

namespace Acme.Product.Settings;

public class ProductSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ProductSettings.MySetting1));
    }
}
