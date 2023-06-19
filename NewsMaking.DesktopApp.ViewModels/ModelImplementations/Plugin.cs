﻿using NewsMaking.DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.DesktopApp.ViewModels.ModelImplementations
{
				public class Plugin : IPlugin
				{
								public string Id { get; set; }
								public string DisplayName { get; set; }
								public string Description { get; set; }
								public int Icon { get; set; }
								public Uri IndexPageAddress { get; set; }
								public Uri SettingsPageAddress { get; set; }
								public Uri HelpPageAddress { get; set; }
				}
}