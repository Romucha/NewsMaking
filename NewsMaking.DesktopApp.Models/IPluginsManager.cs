using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.DesktopApp.Models
{
				public interface IPluginsManager
				{
								string PluginDirectory { get; }

								ObservableCollection<IPlugin> Plugins { get; }

								IPlugin CurrentPlugin { get; set; }

								IAsyncRelayCommand UpdateCommand { get; set; }

								IAsyncRelayCommand CallHelpCommand { get; set; }

								IAsyncRelayCommand<IPlugin> TurnOnCommand { get; set; }

								IAsyncRelayCommand<IPlugin> TurnOffCommand { get; set; }

								IAsyncRelayCommand GetPluginsCommand { get; set; }
				}
}
