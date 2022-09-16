using Volo.Abp.Modularity;

namespace Beekin.App;

[DependsOn(
    typeof(AppApplicationModule),
    typeof(AppDomainTestModule)
    )]
public class AppApplicationTestModule : AbpModule
{

}
