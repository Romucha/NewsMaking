using HtmlAgilityPack;
using Microsoft.Extensions.Logging;
using NewsMaking.DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.DesktopApp.ViewModels
{
    public class PluginFactory : IPluginFactory
    {
        private readonly ILogger<PluginFactory> _logger;
        public PluginFactory(ILogger<PluginFactory> logger)
        {
            _logger = logger;   
        }
        /// <inheritdoc/>
        public async Task<IPlugin> GetPlugin(string PluginAddress)
        {
            try
            {
                HtmlDocument document = new HtmlDocument();
                document.Load(PluginAddress);
                var metadata = document
                               .DocumentNode
                               .Descendants("meta")                               
                               .Where(c => c.GetAttributes("name", "value").Count() > 0 
                                        && c.GetAttributeValue("name", "").Contains("newsmaking"));
                IPlugin plugin = new Plugin()
                {
                    IndexPageAddress = PluginAddress,
                };
                plugin.Id = getPluginAttributeValue(metadata, nameof(plugin.Id));
                plugin.SettingsPageAddress = getPluginAttributeValue(metadata, nameof(plugin.SettingsPageAddress));
                plugin.Icon = int.Parse(getPluginAttributeValue(metadata, nameof(plugin.Icon)));
                plugin.Description = getPluginAttributeValue(metadata, nameof (plugin.Description));
                plugin.DisplayName = getPluginAttributeValue(metadata, nameof(plugin.DisplayName));
                plugin.HelpPageAddress = getPluginAttributeValue(metadata, nameof(plugin.HelpPageAddress));

                return await Task.FromResult(plugin);
            }
            catch (Exception ex) 
            {
                _logger.LogError(ex, "Error has occured while creating plugin");
                throw;
            }
        }

        private string getPluginAttributeValue(IEnumerable<HtmlNode> nodes, string attributeNameValue)
        {
            //how to get value of an attribute
            //get tags with name attribute
            //find the node with the proper name attribute
            //get value of the value attribute

            return nodes.FirstOrDefault(c =>
                                        c.GetAttributes("name")
                                        .Where(c => c.Value.IndexOf($"newsmaking:{attributeNameValue}", StringComparison.OrdinalIgnoreCase) >= 0).Count() == 1)
                        .GetAttributes("value").FirstOrDefault().Value;

        }
    }
}
