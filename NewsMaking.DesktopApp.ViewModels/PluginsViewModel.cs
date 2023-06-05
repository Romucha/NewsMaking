using CommunityToolkit.Mvvm.ComponentModel;
using NewsMaking.DesktopApp.Models;
using System.Collections.ObjectModel;

namespace NewsMaking.DesktopApp.ViewModels
{
				public class PluginsViewModel : ObservableObject
				{
								private ObservableCollection<IPlugin> plugins = new ObservableCollection<IPlugin>();

								public ObservableCollection<IPlugin> Plugins
								{
												get => plugins;
												set => SetProperty(ref plugins, value);
								}

        public PluginsViewModel()
        {
            
        }

								public void Add(IPlugin plugin)
								{
												
								}

								public void Delete(IPlugin plugin)
								{
												
								}
    }
}