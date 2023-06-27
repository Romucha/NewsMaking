using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.DesktopApp.Models
{
    public class PluginManagerSettings : IPluginManagerSettings
    {
        public string PluginDirectoryPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "NewsMaking", "Plugins");

        public string PluginMainFileName => "index.html";

        public PluginManagerSettings()
        {
            if (!Directory.Exists(PluginDirectoryPath)) 
            {
                Directory.CreateDirectory(PluginDirectoryPath);
            }
        }

        public IEnumerable<string> GetPlugins()
        {
            DirectoryInfo pluginDir = new DirectoryInfo(PluginDirectoryPath);
            foreach (FileInfo fileInfo in pluginDir.GetFiles(PluginMainFileName, SearchOption.AllDirectories))
            {
                yield return fileInfo.FullName;
            }
        }
    }
}
