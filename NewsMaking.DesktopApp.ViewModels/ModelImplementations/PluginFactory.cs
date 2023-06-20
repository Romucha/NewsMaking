using HtmlAgilityPack;
using NewsMaking.DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.DesktopApp.ViewModels.ModelImplementations
{
    public class PluginFactory : IPluginFactory
    {
        public PluginFactory()
        {
            
        }

        public async Task<IPlugin> GetPlugin(string PluginAddress)
        {
            HtmlDocument document = new HtmlDocument();
            document.Load(PluginAddress);
            var meta = document.DocumentNode.SelectSingleNode("html").SelectSingleNode("head").SelectNodes("meta");
            return new Plugin()
            {
                IndexPageAddress = PluginAddress,
                DisplayName = "Test plugin"
            };
        }

        private void _parseHtmlPage(HtmlDocument dcoument)
        {
            
        }
    }
}
