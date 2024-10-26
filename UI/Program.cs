using BLL.Helper;
using Microsoft.Extensions.DependencyInjection;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ServiceInjectorHelper.ConfigureServices(services);
            services.AddTransient<EmployeesForm>();

            var serviceProvider = services.BuildServiceProvider();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = serviceProvider.GetRequiredService<EmployeesForm>();
            Application.Run(mainForm);

            
        }
    }
}