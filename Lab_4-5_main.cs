using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
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

namespace NotePad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool Notes_Component, saved_before = false;
        bool opened = false;
        string absolute_path = string.Empty;
        string[] fonts = { "Segoe UI", "Arial", "Bahnschrift", "Tahoma", "Unispace", "Comic Sans MS", "Verdana" };
        string[] size_update = { "bigger", "smaller" };

        public MainWindow()
        {
            InitializeComponent();
            load_on_start();
            FontSizes();
        }

        private void load_on_start()
        {
            Format.Items.Clear();
            Format.ItemsSource = fonts.ToList();
            Format.SelectedIndex = 1;

            if (File.Exists("data.txt"))
            {
                string text1 = File.ReadAllText(@"data.txt");
                Notes_Component = true;     // Convert.ToBoolean(text1);         // Only usable if u want to switch on/off LoadOnStart, thus it will be set to true for lab 4 and false for lab 5
                if (Notes_Component && File.Exists("save.txt")) 
                {
                    string text = File.ReadAllText(@"save.txt");
                    TEXTBOX.Text = text;
                }
            }
        }

        private void FontSizes()
        {
            double[] sizes = new double[22];
            for (int i = 0; i <= 6; i++) // up to 12
                sizes[i] = i + 6;
            for (int i = 7; i <= 18; i++) // up to 36
                sizes[i] = sizes[i - 1] + 2;
            sizes[19] = 48;
            sizes[20] = 72;
            sizes[21] = 144;
            Size.ItemsSource = sizes.ToList();
            Size.SelectedIndex = 12;
        }

        private void save_on_edit()
        {
            string text1 = Notes_Component.ToString();
            File.WriteAllText(@"data.txt", text1);
            if (Notes_Component) 
            {
                string text = TEXTBOX.Text;
                char[] lineFeedChars = { '\n', '\r' };
                string[] cleanTextArray = text.Split(lineFeedChars, StringSplitOptions.RemoveEmptyEntries);
                string cleanText = string.Join(Environment.NewLine, cleanTextArray);
                File.WriteAllText(@"save.txt", cleanText);
            }
        }
        private void Font_change(object sender, SelectionChangedEventArgs e)
        {
            if (Format.IsLoaded && TEXTBOX.IsLoaded) { TEXTBOX.FontFamily = new FontFamily(Format.SelectedItem.ToString()); }
        }

        private void Change_Text_Size(object sender, SelectionChangedEventArgs e)
        {
            if (Size.IsLoaded && TEXTBOX.IsLoaded) 
            {
                TEXTBOX.FontSize = double.Parse(Size.SelectedItem.ToString());
            }
        }

        private void New_window_Button(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            objMainWindow.Show();
        }

        // Dialog window pop up

        private void open_window_button(object sender, RoutedEventArgs e)
        {
            // Конфигурация диалогового окна
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Document";                   // Стандартное имя файла
            dialog.DefaultExt = ".txt";                     // Стандартный формат файла
            dialog.Filter = "Text documents (.txt)|*.txt";  // Фильтрация файлов по формату

            // Открыть диалогове окно открытия файла
            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                opened = true;
                // Открыть документ
                string filePath = dialog.FileName;
                string text = File.ReadAllText(filePath);
                TEXTBOX.Text = text;
                absolute_path = filePath;
                saved_before = true;
            }
        }

        // Normal save with dialog window if saved first time

        private void save_button(object sender, RoutedEventArgs e)
        {
            if (saved_before) 
            {
                string text = TEXTBOX.Text;
                char[] lineFeedChars = { '\n', '\r' };
                string[] cleanTextArray = text.Split(lineFeedChars, StringSplitOptions.RemoveEmptyEntries);
                string cleanText = string.Join(Environment.NewLine, cleanTextArray);
                File.WriteAllText(absolute_path, cleanText);
            }
            else
            {
                // Конфигурация диалогового окна
                var dialog = new Microsoft.Win32.SaveFileDialog();
                dialog.FileName = "Document";                   // Стандартное имя файла
                dialog.DefaultExt = ".txt";                     // Стандартный формат файла
                dialog.Filter = "Text documents (.txt)|*.txt";  // Фильтрация файлов по формату

                // Открыть диалогове окно сохранения файла
                bool? result = dialog.ShowDialog();

                // Process save file dialog box results
                if (result == true)
                {
                    opened = true;
                    // Save document
                    string filePath = dialog.FileName;
                    string text = TEXTBOX.Text;
                    char[] lineFeedChars = { '\n', '\r' };
                    string[] cleanTextArray = text.Split(lineFeedChars, StringSplitOptions.RemoveEmptyEntries);
                    string cleanText = string.Join(Environment.NewLine, cleanTextArray);
                    File.WriteAllText(filePath, cleanText);
                    absolute_path = filePath;
                    saved_before = true;
                }
            }
        }

        private void save_as_button(object sender, RoutedEventArgs e)
        {
            // Конфигурация диалогового окна
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.FileName = "Document";                   // Стандартное имя файла
            dialog.DefaultExt = ".txt";                     // Стандартный формат файла
            dialog.Filter = "Text documents (.txt)|*.txt";  // Фильтрация файлов по формату

            // Открыть диалогове окно сохранения файла
            bool? result = dialog.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                opened = true;
                // Save document
                string filePath = dialog.FileName;
                string text = TEXTBOX.Text;
                char[] lineFeedChars = { '\n', '\r' };
                string[] cleanTextArray = text.Split(lineFeedChars, StringSplitOptions.RemoveEmptyEntries);
                string cleanText = string.Join(Environment.NewLine, cleanTextArray);
                File.WriteAllText(filePath, cleanText);
                absolute_path = filePath;
            }
        }

        private void Button_Notes(object sender, RoutedEventArgs e) // Switch to Notes configuration (PreLoad last Saved) // DEFAULT
        {
            Notes_Component = true;
        }

        private void Button_NotePad(object sender, RoutedEventArgs e)   // Switch to NotePad configuration (Open blank on start)
        {
            Notes_Component = false;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            save_on_edit();
        }



    }
}
