using Microsoft.Win32;
using QWFramework.Core;
using QWFramework.Export;
using QWFramework.Import;
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

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "RTF (*.rtf)|*.rtf";
            if (saveFileDialog.ShowDialog() == true)
            {
                RTF rtf = new RTF(saveFileDialog.FileName, TextBox2.Text);
            }
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XLSX (*.xlsx)|*.XLSX";
            if (saveFileDialog.ShowDialog() == true)
            {
                XLSX rtf = new XLSX(saveFileDialog.FileName, TextBox2.Text);
            }
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XLSX (*.xlsx)|*.XLSX";
            if (openFileDialog.ShowDialog() == true)
            {
                XLSXImporter importer = new XLSXImporter();
                importer.Import(openFileDialog.FileName);
                TextBox1.Text = importer.ReturnOutput();
            }
        }
    }
}
