using System;
using System.Collections.Generic;
using System.IO;
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

namespace NotePad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool Notes_Component = false;
        bool opened = false;

        public MainWindow()
        {
            InitializeComponent();
            load_on_start();
        }

        private void load_on_start()
        {
            if (File.Exists("data.txt"))
            {
                string text1 = File.ReadAllText(@"data.txt");
                Notes_Component = Convert.ToBoolean(text1);
                if (Notes_Component && File.Exists("save.txt")) 
                {
                    string text = File.ReadAllText(@"save.txt");
                    TEXTBOX.Text = text;
                }
            }
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
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void New_window_Button(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            objMainWindow.Show();
        }

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
            }
        }

        private void save_button(object sender, RoutedEventArgs e)
        {
            
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
            }
        }

        private void Button_Notes(object sender, RoutedEventArgs e) // Switch to Notes configuration (PreLoad last Saved) // DEFAULT
        {
            Notes_Component = true;
        }

        private void Button_NotePad(object sender, RoutedEventArgs e)   // Switch to NotePad configuration (Open balnk on start)
        {
            Notes_Component = false;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            save_on_edit();
        }



    }
}
