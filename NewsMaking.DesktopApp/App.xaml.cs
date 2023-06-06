using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;

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
												services.AddWpfBlazorWebView();
												return services.BuildServiceProvider();
								}
				}
}
