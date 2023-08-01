using NewsMaking.DesktopApp.Misc;
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
using System.Windows.Shapes;

namespace NewsMaking.DesktopApp.Views
{
    /// <summary>
    /// Логика взаимодействия для ExpressPanelView.xaml
    /// </summary>
    public partial class ExpressPanelView : Window
    {
        public ExpressPanelView()
        {
            InitializeComponent();
            WindowSettings.SetWindowCornerRound(this);
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Top = System.Windows.SystemParameters.WorkArea.Height - this.Height;
            this.Left = System.Windows.SystemParameters.WorkArea.Width - this.Width;
        }
    }
}
