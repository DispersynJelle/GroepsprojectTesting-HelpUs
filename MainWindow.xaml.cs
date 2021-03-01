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

namespace GroepsprojectTesting_help_
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

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            double Number1 = Convert.ToDouble(txtNumber1.Text);
            double Number2 = Convert.ToDouble(txtNumber2.Text);
            double Result = Number1 - Number2;

            lblResult.Content = Result;
        }

        private void ButtonOptellen_Click(object sender, RoutedEventArgs e)
        {
            var getal1 = Convert.ToDouble(txtNumber1.Text);
            var getal2 = Convert.ToDouble(txtNumber2.Text);

            double Solution = getal1 + getal2;

            lblResult.Content = Solution;
            
        }
    }
}
    
    

