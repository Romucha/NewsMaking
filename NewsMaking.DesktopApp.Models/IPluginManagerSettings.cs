using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.DesktopApp.Models
{
    public interface IPluginManagerSettings
    {
        string PluginDirectoryPath { get; }

        string PluginMainFileName { get; }

        IEnumerable<string> GetPlugins();
    }
}
