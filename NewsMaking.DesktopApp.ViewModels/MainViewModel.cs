using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NewsMaking.DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.DesktopApp.ViewModels
{
				public class MainViewModel : ObservableObject
				{
								public IRelayCommand OpenMainDisplayViewCommand { get; }

								public IRelayCommand OpenExpressPanelViewCommand { get; }

								public IRelayCommand ApplicationShutdownCommand { get; }

								public MainViewModel(IMainActions mainActions)
        {
												OpenMainDisplayViewCommand = new RelayCommand(mainActions.OpenMainDisplayView);
												OpenExpressPanelViewCommand = new RelayCommand(mainActions.OpenExpressPanelView);
												ApplicationShutdownCommand = new RelayCommand(mainActions.ApplicationShutdown);
        }
    }
}
