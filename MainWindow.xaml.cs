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


        
        int calculation ;
        string value1;
        string value2;
        int number2;
        int number1;
        bool btnAdd_Clicked, btnSub_Clicked, btnMult_Clicked, btnDiv_Clicked;

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            value1 = txtvalue1.Text;

            number1 = Convert.ToInt32(value1);

            btnAdd_Clicked = true;
        }


        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            value1 = txtvalue1.Text;

            number1= Convert.ToInt32(txtvalue1.Text);

            btnSub_Clicked = true;
  
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            value1 = txtvalue1.Text;

            number1 = Convert.ToInt32(txtvalue1.Text);

            btnMult_Clicked = true;
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            value1 = txtvalue1.Text;

            number1 = Convert.ToInt32(txtvalue1.Text);

            btnDiv_Clicked = true;
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            value2 = txtvalue2.Text;
            number2 = Convert.ToInt32(value2);

            if (btnAdd_Clicked == true)
            {
                calculation = number1 + number2;
                txtcalculation.Text = calculation.ToString();
            }
            else if (btnSub_Clicked == true)
            {
                calculation = number1 - number2;
                txtcalculation.Text = calculation.ToString();
            }
            else if (btnMult_Clicked == true)
            {
                calculation = number1 * number2;
                txtcalculation.Text = calculation.ToString();
            }
            else if (btnDiv_Clicked == true)
            {
                calculation = number1 / number2;
                txtcalculation.Text = calculation.ToString();
            }

        }
    }
}
