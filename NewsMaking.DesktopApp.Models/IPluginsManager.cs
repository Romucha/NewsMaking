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

								void GetPlugins();

								ObservableCollection<IPlugin> Plugins { get; }

								IPlugin CurrentPlugin { get; }

								void TurnOn(IPlugin plugin);

								void TurnOff(IPlugin plugin);
				}
}
