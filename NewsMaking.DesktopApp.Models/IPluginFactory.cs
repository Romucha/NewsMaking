using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.DesktopApp.Models
{
    /// <summary>
    /// Defines methods of plugin creation.
    /// </summary>
    public interface IPluginFactory
    {
        /// <summary>
        /// Read metadata from html page and parses it into plugin.
        /// </summary>
        /// <param name="PluginAddress">Path to html page of plugin.</param>
        /// <returns></returns>
        Task<IPlugin> GetPlugin(string PluginAddress);
    }
}
