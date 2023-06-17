using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.DesktopApp.Models
{
				public class Plugin : IPlugin
				{
								public string Id { get; set; }
								public string DisplayName { get; set; }
								public string Description { get; set; }
								public int Icon { get; set; }
								public string Url { get; set; }

								public Task HelpAsync()
								{
												throw new NotImplementedException();
								}

								public Task InitializeAsync()
								{
												throw new NotImplementedException();
								}

								public Task TerminateAsync()
								{
												throw new NotImplementedException();
								}

								public Task UpdateAsync()
								{
												throw new NotImplementedException();
								}
				}
}
