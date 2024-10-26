using DAL;
using DAL.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.Helper;

public static class ServiceInjectorHelper
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddSingleton<DataAccessHelper>();
        services.AddTransient<IEmployeeDao, EmployeeDao>();
        services.AddTransient<IEmployeeBusiness, EmployeeBusiness>();
    }
}
