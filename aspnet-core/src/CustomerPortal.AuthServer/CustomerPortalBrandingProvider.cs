using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CustomerPortal;

[Dependency(ReplaceServices = true)]
public class CustomerPortalBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CustomerPortal";
}
