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

namespace C_
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


        string result, number;
        double num1, num2;
        int action;
        bool first = true;


        /*action
         * 0 - nothing
         * 1 - division
         * 2 - multiplication
         * 3 - minus
         * 4 - plus
         */



        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            first = true; action = 0; num1 = 0; num2 = 0;
        }

        private void Button_plus_minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Precentage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            if (first) 
            {print_result("0"); first = false; }
            else { num1 *= 10; number = num1.ToString(); print_result(number); }
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            if (first)
            { print_result("1"); first = false; }
            else { num1 *= 10; num1 += 1; number = num1.ToString(); print_result(number); }
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            if (first)
            { print_result("2"); first = false; }
            else { num1 *= 10; num1 += 2; number = num1.ToString(); print_result(number); }
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            if (first)
            { print_result("3"); first = false; }
            else { num1 *= 10; num1 += 3; number = num1.ToString(); print_result(number); }
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            if (first)
            { print_result("4"); first = false; }
            else { num1 *= 10; num1 += 4; number = num1.ToString(); print_result(number); }
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            if (first)
            { print_result("5"); first = false; }
            else { num1 *= 10; num1 += 5; number = num1.ToString(); print_result(number); }
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            if (first)
            { print_result("6"); first = false; }
            else { num1 *= 10; num1 += 6; number = num1.ToString(); print_result(number); }
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            if (first)
            { print_result("7"); first = false; }
            else { num1 *= 10; num1 += 7; number = num1.ToString(); print_result(number); }
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            if (first)
            { print_result("8"); first = false; }
            else { num1 *= 10; num1 += 8; number = num1.ToString(); print_result(number); }
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            if (first)
            { print_result("9"); first = false; }
            else { num1 *= 10; num1 += 9; number = num1.ToString(); print_result(number); }
        }
        private void Button_Division_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Multiplication_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_point_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Equals_Click(object sender, RoutedEventArgs e)
        {

        }

        void handle_math()
        {

        }

        void print_result(string num1)
        {
            
        }
    }
}
