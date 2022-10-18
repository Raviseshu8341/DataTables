using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Repositories;
using SampleCore.Core.IRepositories;
using SampleCore.Core.IServices;
using Services.Services;
using static Services.Services.Service;

namespace Utilities
{
    public class DIResolver
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            //for accessing the http context by interface in view level
            #region Http context
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            #endregion
            //for service accesssing
            #region Service
            services.AddScoped<IDataService, DataServices>();
            #endregion
            //for database accessing
            #region Repository
            services.AddScoped<IDataRepository, DataRepositories>();
            #endregion
        }
    }
}