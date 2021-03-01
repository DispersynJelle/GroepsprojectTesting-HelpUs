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

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            double dNr1 = Convert.ToDouble(txtNumber1.Text);

            double dNr2 = Convert.ToDouble(txtNumber2.Text);

            double dResult = dNr1 * dNr2;

            lblResult.Content = dResult.ToString();
        }
    }
}
