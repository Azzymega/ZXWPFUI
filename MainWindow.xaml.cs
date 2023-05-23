using QWFramework.Core;
using QWWPFUI.Pages;
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

namespace QWWPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UndefinedIntegral? integral;
        private NavigationService navigationService;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                integral = new UndefinedIntegral(TextBox1.Text, new UndefineIntegralEvaluator(TextBox1.Text));
                TextBox2.Text = integral.ReturnAnswer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Вы ошиблись при вводе.");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(new InstructionPage());
        }
    }
}
