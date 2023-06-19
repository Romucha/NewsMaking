using NewsMaking.DesktopApp.Models;
using NewsMaking.DesktopApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NewsMaking.DesktopApp.ViewModels.ModelImplementations
{
    public class MainActions : IMainActions
    {
        public Action OpenMainDisplayView => () => { new MainDisplayView().Show(); };

        public Action OpenExpressPanelView => () => { new ExpressPanelView().Show(); };

        public Action ApplicationShutdown => () => { Application.Current.Shutdown(); };
    }
}