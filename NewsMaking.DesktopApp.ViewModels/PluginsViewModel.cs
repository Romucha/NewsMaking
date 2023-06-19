﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using NewsMaking.DesktopApp.Models;
using NewsMaking.DesktopApp.ViewModels.ModelImplementations;
using System.Collections.ObjectModel;

namespace NewsMaking.DesktopApp.ViewModels
{
    public class PluginsViewModel : ObservableObject, IPluginsManager
    {
        private ObservableCollection<IPlugin> plugins;

        public ObservableCollection<IPlugin> Plugins
        {
            get => plugins;
            set => SetProperty(ref plugins, value);
        }

        private IPlugin currentPlugin;

        public IPlugin CurrentPlugin
        {
            get => currentPlugin;
            set => SetProperty(ref currentPlugin, value);
        }

        public string PluginDirectory { get; }

        public IAsyncRelayCommand UpdateCommand { get; set; }
        public IAsyncRelayCommand CallHelpCommand { get; set; }
        public IAsyncRelayCommand<IPlugin> TurnOnCommand { get; set; }
        public IAsyncRelayCommand<IPlugin> TurnOffCommand { get; set; }
        public IAsyncRelayCommand GetPluginsCommand { get; set; }

        public PluginsViewModel()
        {
            plugins = new ObservableCollection<IPlugin>();
            UpdateCommand = new AsyncRelayCommand(_update);
            CallHelpCommand = new AsyncRelayCommand(_callHelp);
            TurnOnCommand = new AsyncRelayCommand<IPlugin>(_turnOn);
            TurnOffCommand = new AsyncRelayCommand<IPlugin>(_turnOff);
            GetPluginsCommand = new AsyncRelayCommand(_getPlugins);
        }

        private async Task _update()
        {
            throw new NotImplementedException();
        }

        private async Task _callHelp()
        {
            throw new NotImplementedException();
        }

        private async Task _turnOn(IPlugin plugin)
        {
            throw new NotImplementedException();
        }

        private async Task _turnOff(IPlugin plugin)
        {
            throw new NotImplementedException();
        }

        private async Task _getPlugins()
        {
            Plugins.Add(new Plugin()
            {
                DisplayName = "google",
                IndexPageAddress = new Uri("https://google.com")
            });
            Plugins.Add(new Plugin()
            {
                DisplayName = "yandex",
                IndexPageAddress = new Uri("https://ya.ru")
            });
            Plugins.Add(new Plugin()
            {
                DisplayName = "stackoverflow",
                IndexPageAddress = new Uri("https://stackoverflow.com")
            });

            await Task.CompletedTask;
        }
    }
}