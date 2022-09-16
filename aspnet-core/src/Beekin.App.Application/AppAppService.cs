using System;
using System.Collections.Generic;
using System.Text;
using Beekin.App.Localization;
using Volo.Abp.Application.Services;

namespace Beekin.App;

/* Inherit your application services from this class.
 */
public abstract class AppAppService : ApplicationService
{
    protected AppAppService()
    {
        LocalizationResource = typeof(AppResource);
    }
}
