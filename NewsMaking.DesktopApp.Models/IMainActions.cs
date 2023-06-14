using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.DesktopApp.Models
{
				public interface IMainActions
				{
								Action OpenMainDisplayView { get; }

								Action OpenExpressPanelView { get; }

								Action ApplicationShutdown { get; }
				}
}
