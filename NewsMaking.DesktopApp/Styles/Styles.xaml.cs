using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NewsMaking.DesktopApp.Styles
{
    public partial class Styles
    {
        private void minimize_btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Button btn = sender as Button;
            (btn.TemplatedParent as Window).WindowState = WindowState.Minimized;
        }

        private void close_btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Button btn = sender as Button;
            (btn.TemplatedParent as Window).Close();
        }
    }
}
