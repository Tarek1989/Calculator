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

namespace WPFCalculator
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


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int value1, value2, calculation;

            value1 = Convert.ToInt32(txtvalue1.Text);
            value2 = Convert.ToInt32(txtvalue2.Text);
            calculation = value1 + value2;
            txtcalculation.Text = calculation.ToString();
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            int value1, value2, calculation;

            value1 = Convert.ToInt32(txtvalue1.Text);
            value2 = Convert.ToInt32(txtvalue2.Text);
            calculation = value1 - value2;
            txtcalculation.Text = calculation.ToString();
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            int value1, value2, calculation;

            value1 = Convert.ToInt32(txtvalue1.Text);
            value2 = Convert.ToInt32(txtvalue2.Text);
            calculation = value1 * value2;
            txtcalculation.Text = calculation.ToString();


        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            int value1, value2, calculation;

            value1 = Convert.ToInt32(txtvalue1.Text);
            value2 = Convert.ToInt32(txtvalue2.Text);
            calculation = value1 / value2;
            txtcalculation.Text = calculation.ToString();


        }


    }
}
