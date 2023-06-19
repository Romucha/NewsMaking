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

        public IPlugin GetPlugin(Uri PluginPage)
        {
            HtmlDocument document = new HtmlDocument();
            document.Load(PluginPage.AbsolutePath);
            return null;
        }

        private void _parseHtmlPage(HtmlDocument dcoument)
        {
            
        }
    }
}
