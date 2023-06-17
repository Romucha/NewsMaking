using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Logging;
using NewsMaking.DesktopApp.Models;
using System.Collections.ObjectModel;

namespace NewsMaking.DesktopApp.ViewModels
{
				public class PluginsViewModel : ObservableObject
				{
								private ObservableCollection<IPlugin> plugins;

								public ObservableCollection<IPlugin> Plugins
								{
												get => plugins;
												set => SetProperty(ref plugins, value);
								}

								private IPlugin currentPlugin;

								public IPlugin CurrentPlugin
								{
												get => currentPlugin;
												set => SetProperty(ref currentPlugin, value);
								}

								public PluginsViewModel()
        {
												plugins = new ObservableCollection<IPlugin>();
												SeedData();
								}

								public void Add(IPlugin plugin)
								{
												Plugins.Add(plugin);
								}

								public void Delete(IPlugin plugin)
								{
												Plugins.Remove(plugin);
								}

								public void SeedData()
								{
												Plugins.Add(new Plugin()
												{
																DisplayName = "google",
																Url = "https://google.com"
												});
												Plugins.Add(new Plugin()
												{
																DisplayName = "yandex",
																Url = "https://ya.ru"
												});
												Plugins.Add(new Plugin()
												{
																DisplayName = "stackoverflow",
																Url = "https://stackoverflow.com"
												});
								}
    }
}