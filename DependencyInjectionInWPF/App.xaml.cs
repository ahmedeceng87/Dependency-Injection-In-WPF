using DataAccessLibrary;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace DependencyInjectionInWPF
{    
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;       

        private void ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<MainWindow>();
            services.AddTransient<IDataAccess, DataAccess>();
            services.AddTransient<ChildWindow>();            
            serviceProvider = services.BuildServiceProvider();
            services.AddSingleton<IServiceProvider>(serviceProvider);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            ConfigureServices();
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
            base.OnStartup(e);
        }
    }
}
