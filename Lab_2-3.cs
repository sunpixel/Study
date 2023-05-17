using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

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
        double num1, num2 = 0;
        int action;
        int num = 0;
        bool first = true;
        bool dec, swap, point, calc_performed = false;

        List<string> istor = new List<string>();



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
            first = true; action = 0; num1 = 0; num2 = 0; number = "0"; dec = false; result = null; print_result(result); swap = false; calc_performed = false;
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
                if (first)
                {
                    first = true;
                    number = "0"; result = "0"; print_result(result);
                }
                else { number += 0; result += 0; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first & !dec)
                {
                    if (first & point == false) { point = true; number = "0"; result += "0"; print_result(result); }
                    else if (point) { }
                    else { number = "0"; result += "0"; print_result(result); }
                }
                else { number += 0; result += 0; print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first)
                {
                    first = false;
                    number = "1"; result = "1"; print_result(result);
                }
                else { number += 1; result += 1; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first)
                {
                    first = false;
                    number = "1"; result += "1"; print_result(result);
                }
                else { number += 1; result += 1; print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first)
                {
                    first = false;
                    number = "2"; result = "2"; print_result(result);
                }
                else { number += 2; result += 2; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first)
                {
                    first = false;
                    number = "2"; result += "2"; print_result(result);
                }
                else { number += 2; result += 2; print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first)
                {
                    first = false;
                    number = "3"; result = "3"; print_result(result);
                }
                else { number += 3; result += 3; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first)
                {
                    first = false;
                    number = "3"; result += "3"; print_result(result);
                }
                else { number += 3; result += 3; print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first)
                {
                    first = false;
                    number = "4"; result += "4"; print_result(result);
                }
                else { number += 4; result += 4; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first)
                {
                    first = false;
                    number = "4"; result += "4"; print_result(result);
                }
                else { number += 4; result += 4; print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first)
                {
                    first = false;
                    number = "5"; result = "5"; print_result(result);
                }
                else { number += 5; result += 5; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first)
                {
                    first = false;
                    number = "5"; result += "5"; print_result(result);
                }
                else { number += 5; result += 5; print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first)
                {
                    first = false;
                    number = "6"; result = "6"; print_result(result);
                }
                else { number += 6; result += 6; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first)
                {
                    first = false;
                    number = "6"; result += "6"; print_result(result);
                }
                else { number += 6; result += 6; print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first)
                {
                    first = false;
                    number = "7"; result = "7"; print_result(result);
                }
                else { number += 7; result += 7; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first)
                {
                    first = false;
                    number = "7"; result += "7"; print_result(result);
                }
                else { number += 7; result += 7; print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first)
                {
                    first = false;
                    number = "8"; result = "8"; print_result(result);
                }
                else { number += 8; result += 8; print_result(result); }

                num1 = double.Parse(number);
            }
            else
            {
                if (first)
                {
                    first = false;
                    number = "8"; result += "8"; print_result(result);
                }
                else { number += 8; result += 8; print_result(result); }
                num2 = double.Parse(number);
            }
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            if (swap != true)
            {
                if (first)
                {
                    first = false;
                    number = "9"; result = "9"; print_result(result);
                }
                else { number += 9; result += 9; print_result(result); }
                num1 = double.Parse(number);
            }
            else
            {
                if (first)
                {
                    first = false;
                    number = "9"; result += "9"; print_result(result);
                }
                else { number += 9; result += 9; print_result(result); }
                num2 = double.Parse(number);
            }
        }
        private void Button_Division_Click(object sender, RoutedEventArgs e)
        {
            if (action != 0 & action == 1 & !calc_performed) { num1 = handle_math(1); result += " = "; result += num1.ToString(); first = true; dec = false; if (History_enable.IsChecked == true) { istor.Add(result); } print_result(result); }
            else if (calc_performed) { action = 1; result += " / "; swap = true; number = null; print_result(result); first = true; dec = false; }
            else if (action != 0) { calc_performed = false; num1 = handle_math(action); action = 1; result += " / "; swap = true; number = null; print_result(result); first = true; dec = false; }
            else { num1 = double.Parse(number); action = 1; result += " / "; swap = true; number = null; print_result(result); first = true; dec = false; }
        }

        private void Button_Multiplication_Click(object sender, RoutedEventArgs e)
        {
            if (action != 0 & action == 2 & !calc_performed) { num1 = handle_math(2); result += " = "; result += num1.ToString(); first = true; dec = false; if (History_enable.IsChecked == true) { istor.Add(result); } print_result(result); }
            else if (calc_performed) { action = 2; result += " * "; swap = true; number = null; print_result(result); first = true; dec = false; }
            else if (action != 0) { calc_performed = false; num1 = handle_math(action); action = 2; result += " * "; swap = true; number = null; print_result(result); first = true; dec = false; }
            else { num1 = double.Parse(number); action = 2; result += " * "; swap = true; number = null; print_result(result); first = true; dec = false; }
        }

        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            if (action != 0 & action == 3 & !calc_performed) { num1 = handle_math(3); result += " = "; result += num1.ToString(); first = true; dec = false; if (History_enable.IsChecked == true) { istor.Add(result); } print_result(result); }
            else if (calc_performed) { action = 3; result += " - "; swap = true; number = null; print_result(result); first = true; dec = false; }
            else if (action != 0) { calc_performed = false; num1 = handle_math(action); action = 3; result += " - "; swap = true; number = null; print_result(result); first = true; dec = false; }
            else { num1 = double.Parse(number); action = 3; result += " - "; swap = true; number = null; print_result(result); first = true; dec = false; }
        }


        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            if (action != 0 & action == 4 & !calc_performed) { num1 = handle_math(4); result += " = "; result += num1.ToString(); first = true; dec = false; if (History_enable.IsChecked == true) { istor.Add(result); } print_result(result); }
            else if (calc_performed) { action = 4; result += " + "; swap = true; number = null; print_result(result); first = true; dec = false; }
            else if (action != 0) { calc_performed = false; num1 = handle_math(action); action = 4; result += " + "; swap = true; number = null; print_result(result); first = true; dec = false; }
            else { num1 = double.Parse(number); action = 4; result += " + "; swap = true; number = null; print_result(result); first = true; dec = false; }
        }


        private void Button_point_Click(object sender, RoutedEventArgs e)
        {
            if (dec == true) { }
            else
            {
                if (first & num1 == 0) { result = "0."; number = "0,"; first = false; }
                else
                {
                    first = false;
                    point = false;
                    dec = true;
                    result += ".";
                    number += ",";
                }
                print_result(result);
            }
        }


        private void Button_Equals_Click(object sender, RoutedEventArgs e)
        {
            if (action != 0)
            {
                num1 = handle_math(action); result += " = "; result += num1.ToString(); if (History_enable.IsChecked == true) { istor.Add(result); }
                print_result(result);
                result = num1.ToString(); calc_performed = true; swap = false; first = true;
            }
            else { }
        }

        private void delete_all_Click(object sender, RoutedEventArgs e)
        {
            istor.Clear(); History.Items.Clear(); num = 0;
        }

        private void delete_last_Click(object sender, RoutedEventArgs e)
        {
            if (istor.Count != 0)
            {
                istor.RemoveAt(istor.Count - 1); History.Items.RemoveAt(istor.Count);
                if (num != 0) { num--; }
            }
            else { }
        }

        private void History_disabled(object sender, RoutedEventArgs e)
        {
            if (History_enable.IsChecked == false) { History.Visibility = Visibility.Hidden; delete_last.Visibility = Visibility.Hidden; delete_all.Visibility = Visibility.Hidden; }
        }

        private void History_eanbled(object sender, RoutedEventArgs e)
        {
            if (History_enable.IsChecked == true) { History.Visibility = Visibility.Visible; delete_last.Visibility = Visibility.Visible; delete_all.Visibility = Visibility.Visible; }
        }

        double handle_math(int var)
        {
            if (var == 1)
            {
                if (num2 == 0) { Result.Text = "Zero division Error!!"; Task.Delay(2000); return Math.Round(num1, 2); }
                else { num1 = num1 / num2; return Math.Round(num1, 2); }
            }
            else if (var == 2) { num1 = num1 * num2; return Math.Round(num1, 2); }
            else if (var == 3) { num1 = num1 - num2; return Math.Round(num1, 2); }
            else if (var == 4) { num1 = num1 + num2; return Math.Round(num1, 2); }
            else { return num1; }
        }

        private void History_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        void print_result(string numer)
        {
            Result.Text = numer;
            if (istor.Count == 0) { }
            else if (istor.Count == num) { }
            else { History.Items.Add(istor[num]); num++; }
        }
    }
}
