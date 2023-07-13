using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PaymentService;

[Dependency(ReplaceServices = true)]
public class PaymentServiceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PaymentService";
}
