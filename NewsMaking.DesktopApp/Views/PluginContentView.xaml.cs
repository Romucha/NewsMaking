using NewsMaking.DesktopApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewsMaking.DesktopApp.Views
{
    /// <summary>
    /// Логика взаимодействия для PluginContentView.xaml
    /// </summary>
    public partial class PluginContentView : UserControl
    {
        public PluginContentView()
        {
            InitializeComponent();
            DataContext = App.Services.GetService(typeof(PluginsViewModel));
        }

        public PluginsViewModel ViewModel => (PluginsViewModel)DataContext;
    }
}
