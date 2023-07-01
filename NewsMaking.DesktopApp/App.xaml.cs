using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using NewsMaking.DesktopApp.Models;
using NewsMaking.DesktopApp.ViewModels;
using NewsMaking.DesktopApp.ViewModels.ModelImplementations;
using NLog.Extensions.Logging;

namespace NewsMaking.DesktopApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Services = ConfigureServices();

            this.InitializeComponent();
        }

        /// <summary>
        /// Gets the current <see cref="App"/> instance in use.
        /// </summary>
        public new static App Current => (App)Application.Current;

        /// <summary>
        /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
        /// </summary>
        public static IServiceProvider Services { get; private set; }

        /// <summary>
        /// Configures the services for the application.
        /// </summary>
        private static IServiceProvider ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            /*
												services.AddSingleton<IFilesService, FilesService>();
												services.AddSingleton<ISettingsService, SettingsService>();
												services.AddSingleton<IClipboardService, ClipboardService>();
												services.AddSingleton<IShareService, ShareService>();
												services.AddSingleton<IEmailService, EmailService>();
												*/
            services.AddLogging(c => c.AddNLog());
            services.AddTransient<IMainActions, MainActions>();
            services.AddTransient<MainViewModel>();
            services.AddTransient<IPluginManagerSettings, PluginManagerSettings>();
            services.AddSingleton<PluginsViewModel>();
            services.AddTransient<IPluginFactory, PluginFactory>();
            return services.BuildServiceProvider();
        }
    }
}
