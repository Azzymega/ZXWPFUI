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
    /// Логика взаимодействия для InstructionPage.xaml
    /// </summary>
    public partial class InstructionPage : Page
    {
        private NavigationWindow NavigationWindow;
        public InstructionPage(NavigationWindow NavigationWindow)
        {
            InitializeComponent();
            this.NavigationWindow = NavigationWindow;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationWindow.Navigate(new ProgramPage(NavigationWindow));
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow.Navigate(new IntegralsPage(NavigationWindow));
        }
    }
}
