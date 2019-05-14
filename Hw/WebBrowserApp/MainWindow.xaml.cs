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

namespace WebBrowserApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseTabClick(object sender, RoutedEventArgs e)
        {
            var selectedTab = tabControl.SelectedItem;
            if(selectedTab != addTabItem)
            tabControl.Items.Remove(selectedTab);
            
        }

        private void OpenTabClick(object sender, RoutedEventArgs e)
        {
            Uri googleUri = new Uri("https://google.com/");
            tabControl.Items.Insert(tabControl.Items.IndexOf(addTabItem), new TabItem { Header = "New Tab", Content = new WebBrowser { Source = googleUri } });
        }
        private void addTabItemClick(object sender, MouseButtonEventArgs e)
        {
            Uri googleUri = new Uri("https://google.com/");
            tabControl.Items.Insert(tabControl.Items.IndexOf(addTabItem), new TabItem { Header = "New Tab", Content = new WebBrowser { Source = googleUri } });
        }
    }
}
