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

        private void maximize_btn_Click(object sender, RoutedEventArgs e)
        {
             Button btn = sender as Button;
             if ((btn.TemplatedParent as Window).WindowState == WindowState.Maximized) 
             { 
                 (btn.TemplatedParent as Window).WindowState = WindowState.Normal;
                 btn.Content = "🗖";
             }
             else if ((btn.TemplatedParent as Window).WindowState == WindowState.Normal)
             {
                 (btn.TemplatedParent as Window).WindowState = WindowState.Maximized;
                 btn.Content = "❐";
             }
        }
    }
}
