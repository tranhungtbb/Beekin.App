using Beekin.App.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Beekin.App;

[DependsOn(
    typeof(AppEntityFrameworkCoreTestModule)
    )]
public class AppDomainTestModule : AbpModule
{

}
