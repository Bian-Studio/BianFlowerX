using ModernWpf.Controls;
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

namespace BianFlowerX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        public static Uri dyuri(string a)
        {
            Uri date = new Uri("/BianFlowerX;component/Pages/" + a + ".xaml", UriKind.RelativeOrAbsolute);
            return date;
        }
        private void Item(ModernWpf.Controls.NavigationView sender, ModernWpf.Controls.NavigationViewItemInvokedEventArgs args)
        { 
            if (args.IsSettingsInvoked)
            {
                //Settings
                View.Source = new Uri("/Pages/Settings.xaml", UriKind.RelativeOrAbsolute);
            }
            else
            {
                NavigationViewItem viewItem = nvSample.SelectedItem as NavigationViewItem;
                switch (viewItem.Tag)
                {
                    case "Home":
                        View.Navigate(dyuri("Home"));
                        break;
                    case "Game":
                        View.Navigate(dyuri("/Pages/Game.xaml"));
                        break;
                    case "Download":
                        View.Navigate(dyuri("/Pages/Download.xaml"));
                        break;
                    case "Online":
                        View.Navigate(dyuri("/Pages/Online.xaml"));
                        break;
                    case "About":
                        View.Navigate(dyuri("/Pages/About.xaml"));
                        break;
                    case "Setting":
                        View.Navigate(dyuri("/Pages/Settings.xaml"));
                        break;
                }
            }
        }
    }
}
