using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
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
        bool dec, swap = false;


        /*action
         * 0 - nothing
         * 1 - division
         * 2 - multiplication
         * 3 - minus
         * 4 - plus
         * 5 - Equals
         */



        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            first = true; action = 0; num1 = 0; num2 = 0; number = "0"; dec = false; result = null; print_result(result); swap = false;
        }

        private void Button_plus_minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Precentage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first) { first = true;
                   number = "0"; result = "0"; print_result(result); }
                else { number += 0; result += 0; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first) { first = true;
                   number = "0"; result = "0"; print_result(result); }
                else { number += 0; result += 0; print_result(result); }
                num2 = double.Parse(number);
            }
        }

            private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first) { first = false;
                   number = "1"; result = "1"; print_result(result); }
                else { number += 1; result += 1; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first) { first = false;
                   number = "1"; result = "1"; print_result(result); }
                else { number += 1; result += 1;  print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first) { first = false;
                   number = "2"; result = "2"; print_result(result); }
                else { number += 2; result += 2; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first) {first = false;
                    number = "2"; result = "2"; print_result(result); }
                else { number += 2; result += 2; print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first) {first = false;
                    number = "3"; result = "3"; print_result(result); }
                else { number += 3; result += 3; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first) {first = false;
                    number = "3"; result = "3"; print_result(result); }
                else { number += 3; result += 3; print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first) {first = false;
                    number = "4"; result += "4"; print_result(result); }
                else { number += 4; result += 4; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first) {first = false;
                    number = "4"; result = "4"; print_result(result); }
                else { number += 4; result += 4; print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first) {first = false;
                    number = "5"; result = "5"; print_result(result); }
                else { number += 5; result += 5; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first) {first = false;
                    number = "5"; result = "5"; print_result(result); }
                else { number += 5; result += 5; print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first) {first = false;
                    number = "6"; result = "6"; print_result(result); }
                else { number += 6; result += 6; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first) {first = false;
                    number = "6"; result = "6"; print_result(result); }
                else { number += 6; result += 6; print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first) {first = false;
                    number = "7"; result = "7"; print_result(result); }
                else { number += 7; result += 7; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first) {first = false; 
                   number = "7"; result = "7"; print_result(result); }
                else { number += 7; result += 7; print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first) { first = false; 
                   number = "8"; result = "8"; print_result(result); }
                else { number += 8; result += 8; print_result(result); }

                num1 = double.Parse(number);
            }
            else
            {
                if (first) { first = false;
                   number = "8"; result = "8"; print_result(result); }
                else{ number += 8; result += 8; print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first) { first = false;
                   number = "9"; result = "9"; print_result(result); }
                else { number += 9; result += 9; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first) { first = false; 
                   number = "9"; result = "9"; print_result(result); }
                else { number += 9; result += 9; print_result(result); }
                num2 = double.Parse(number);
            }
        }
        private void Button_Division_Click(object sender, RoutedEventArgs e)
        {
            if (action != 0) { num1 = handle_math(1); print_result(num1.ToString()); }
            else { action = 1; }
        }

        private void Button_Multiplication_Click(object sender, RoutedEventArgs e)
        {
            action = 2;
        }

        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            action = 3;
        }

        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            action = 4;
        }

        private void Button_point_Click(object sender, RoutedEventArgs e)
        {
            if (dec == true) { }
            else
            {
                first = false;
                dec = true;
                result += ".";
                print_result(result);
            }
        }

        private void Button_Equals_Click(object sender, RoutedEventArgs e)
        {
            
        }

        double handle_math(int var)
        {
            if (num2 != 0)
            {
                if (var == 1)
                {
                    if (num2 == 0) { print_result("Zero division error"); return 0; }
                    else { num1 = num1 / num2; return num1; }
                }
                else if (var == 2) { num1 = num1 * num2; return num1; }
                else if (var == 3) { num1 = num1 - num2; return num1; }
                else if (var == 4) { num1 = num1 + num2; return num1; }
                else { return num1; }
            }
            else { return num1; }
        }

        void print_result(string num)
        {

            Result.Text = num;
        }
    }
}
