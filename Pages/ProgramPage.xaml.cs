using QWFramework.Core;
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
    /// Логика взаимодействия для ProgramPage.xaml
    /// </summary>
    public partial class ProgramPage : Page
    {
        private NavigationWindow NavigationWindow;
        private UndefinedIntegral? integral;
        public ProgramPage(NavigationWindow NavigationWindow)
        {
            InitializeComponent();
            this.NavigationWindow = NavigationWindow;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                integral = new UndefinedIntegral(TextBox1.Text, new UndefineIntegralEvaluator(TextBox1.Text));
                TextBox2.Text = integral.ReturnAnswer();
            }
            catch
            {
                MessageBox.Show("Вы ошиблись при вводе.");
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationWindow.Navigate(new InstructionPage(NavigationWindow));
        }
    }
}
