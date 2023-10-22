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

namespace GA_2_JuanHernandez
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

        private void btnFullName_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string fullName = $"{firstName} {lastName}";
            MessageBox.Show(fullName);
        }// btnFullName_Click

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //string number1 = txtNumber1.Text;
            //string number2 = txtNumber2.Text;
            //string sign = " + ";
            //string equalSign = " = ";
            //string result = number1 + number2;
            //string equation = $"{number1} {sign} {number2} {equalSign} {result}";
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);
            string sign = " + ";
            string equalSign = " = ";
            int result = num1 + num2;
            string equation = $"{number1} {sign} {number2} {equalSign} {result}";
            lblEquation.Content = equation;
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);
            string sign = " - ";
            string equalSign = " = ";
            int result = num1 - num2;
            string equation = $"{number1} {sign} {number2} {equalSign} {result}";
            lblEquation.Content = equation;
        }
    }
}
