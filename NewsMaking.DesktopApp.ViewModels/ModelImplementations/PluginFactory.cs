using HtmlAgilityPack;
using NewsMaking.DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.DesktopApp.ViewModels.ModelImplementations
{
				public class PluginFactory : IPluginFactory
				{
								public IPlugin GetPlugin(Uri PluginPage)
								{
												throw new NotImplementedException();
								}

								private void _parseHtmlPage(Stream stream) 
								{
												HtmlDocument document = new HtmlDocument();
												document.Load(stream);

								}
				}
}
