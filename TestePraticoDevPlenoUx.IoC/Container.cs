using Microsoft.Extensions.DependencyInjection;
using TestePraticoDevPlenoUx.Application;
using TestePraticoDevPlenoUx.Domain.Services;
using TestePraticoDevPlenoUx.Domain.Services.Facades;
using TestePraticoDevPlenoUx.Domain.Services.Facades.Interfaces;
using TestePraticoDevPlenoUx.Domain.Services.Interfaces;

namespace TestePraticoDevPlenoUx.IoC
{
    public static class Container
    {
        public static void Register(this IServiceCollection services)
        {
            #region Applications
            services.AddScoped(typeof(AgendaApplication));
            #endregion

            #region Services
            services.AddScoped(typeof(IAgendaService), typeof(AgendaService));
            #endregion

            #region Facades
            services.AddScoped(typeof(IAgendaFacade), typeof(AgendaFacade));
            #endregion

            #region Repositories
            #endregion
        }
    }
}
