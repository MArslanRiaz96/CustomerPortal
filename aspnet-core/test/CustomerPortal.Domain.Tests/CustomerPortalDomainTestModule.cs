using CustomerPortal.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CustomerPortal;

[DependsOn(
    typeof(CustomerPortalEntityFrameworkCoreTestModule)
    )]
public class CustomerPortalDomainTestModule : AbpModule
{

}
