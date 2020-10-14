using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Currency_Apps
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Hitung_Click(object sender, RoutedEventArgs e)
        {
            var nominalString = InputTextBox.Text;
            Regex regex = new Regex("[^0-9.-]+");
            if (!regex.IsMatch(nominalString))
            {
                var nominalDouble = Convert.ToDouble(nominalString);
                resultLabel.Content = Convert.ToString(nominalDouble * 15000);
            }

            else
            {
                resultLabel.Content = "Invalid";
            }
        }
    }
}
