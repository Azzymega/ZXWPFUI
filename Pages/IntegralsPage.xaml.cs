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

namespace QWWPFUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для IntegralsPage.xaml
    /// </summary>
    public partial class IntegralsPage : Page
    {
        private NavigationWindow NavigationWindow;
        public IntegralsPage(NavigationWindow NavigationWindow)
        {
            this.NavigationWindow = NavigationWindow;
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationWindow.GoBack();
        }
    }
}
