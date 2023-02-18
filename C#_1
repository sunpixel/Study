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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string number = "";
        float trans = -1;   // Во что превратится число в итоге
        float[] numbers = new float[] { };
        int[] action = new int[] { };
        private void Action_clear_Click(object sender, RoutedEventArgs e)
        {
            number = "0";
            Array.Clear(numbers, 0, numbers.Length);
            Array.Clear(action, 0, action.Length);
            Edit_text();
        }


        private void Number_one_Click(object sender, RoutedEventArgs e)
        {
            number += "1";
            Edit_text();
        }

        private void Number_two_Click(object sender, RoutedEventArgs e)
        {
            number += "2";
            Edit_text();
        }

        private void Number_three_Click(object sender, RoutedEventArgs e)
        {
            number += "3";
            Edit_text();
        }

        private void Number_four_Click(object sender, RoutedEventArgs e)
        {
            number += "4";
            Edit_text();
        }

        private void Number_five_Click(object sender, RoutedEventArgs e)
        {
            number += "5";
            Edit_text();
        }

        private void Number_six_Click(object sender, RoutedEventArgs e)
        {
            number += "6";
            Edit_text();
        }

        private void Number_seven_Click(object sender, RoutedEventArgs e)
        {
            number += "7";
            Edit_text();
        }

        private void Number_eight_Click(object sender, RoutedEventArgs e)
        {
            number += "8";
            Edit_text();
        }

        private void Number_nine_Click(object sender, RoutedEventArgs e)
        {
            number += "9";
            Edit_text();
        }

        private void Number_zero_Click(object sender, RoutedEventArgs e)
        {
            number += "0";
            Edit_text();
        }
        private void Action_plus_Click(object sender, RoutedEventArgs e)
        {
            trans = float.Parse(number);
            numbers.Append(trans);
            trans = 0;
            action.Append(0);
        }

        private void Action_minus_Click(object sender, RoutedEventArgs e)
        {
            trans = float.Parse(number);
            numbers.Append(trans);
            trans = 0;
            action.Append(1);
        }

        private void Action_multiply_Click(object sender, RoutedEventArgs e)
        {
            trans = float.Parse(number);
            numbers.Append(trans);
            trans = 0;
            action.Append(2);
        }

        private void Action_divide_Click(object sender, RoutedEventArgs e)
        {
            trans = float.Parse(number);
            numbers.Append(trans);
            trans = 0;
            action.Append(3);
        }

        private void Action_dot_Click(object sender, RoutedEventArgs e)
        {
            trans = float.Parse(number);
            numbers.Append(trans);
            trans = 0;
            action.Append(4);
        }
        private void Action_plus_minus_Click(object sender, RoutedEventArgs e)
        {
            trans = float.Parse(number);
            numbers.Append(trans);
            trans = 0;
            action.Append(5);
        }

        private void Action_precentage_Click(object sender, RoutedEventArgs e)
        {
            trans = float.Parse(number);
            numbers.Append(trans);
            trans = 0;
            action.Append(6);
        }


        private void Action_calculate_Click(object sender, RoutedEventArgs e)
        {
            
        }
        
        private void Edit_text()
        {
            View_port.Text = number.ToString();
        }
    }
}
