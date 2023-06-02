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
using System.Speech.Synthesis;
using System.IO;

namespace Voice_Synthesis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] files = {"Открыть", "Сохранить", "Выйти"};
        bool isSpeaking = false;

        private SpeechSynthesizer SpeechSynthesizer;

        public MainWindow()
        {
            InitializeComponent();
            AddItems();
        }

        private void AddItems()
        {
            File_dialog.Items.Clear();
            File_dialog.ItemsSource = files.ToList();
            File_dialog.SelectedItem = 0;
        }

        private void File_dialog_selection_change(object sender, SelectionChangedEventArgs e)
        {
            if (File_dialog.IsLoaded && Input_text.IsLoaded)
            {
                int selectedItem = File_dialog.SelectedIndex;

                if (selectedItem == 0) { open_file(); }
                if (selectedItem == 1) { save_file(); }
                if (selectedItem == 2) { Close(); }
            }
        }

        private void Play_button_Click(object sender, RoutedEventArgs e)
        {
            if (!isSpeaking)
            {
                SpeechSynthesizer = new SpeechSynthesizer();
                SpeechSynthesizer.Volume = Convert.ToInt16(Volume_Slider.Value);
                SpeechSynthesizer.Rate = Convert.ToInt16(Speed_Slider.Value);
                //SpeechSynthesizer.SetOutputToWaveFile(@"aduio.wav");
                SpeechSynthesizer.SpeakAsync(Input_text.Text);
                isSpeaking = true;
            }
        }

        private void Stop_button_Click(object sender, RoutedEventArgs e)
        {
            if (isSpeaking) 
            {
                SpeechSynthesizer.SpeakAsyncCancelAll();
                isSpeaking = false;
            }
        }
        private void volume_change(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            bool def = false;
            if (def) { Volume_OutPut.Text = "Скорость" + Volume_Slider.Value.ToString(); }
            else { def = true; }
        }

        private void speed_change(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void open_file()
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Document";                   // Стандартное имя файла
            dialog.DefaultExt = ".txt";                     // Стандартный формат файла
            dialog.Filter = "Text documents (.txt)|*.txt";  // Фильтрация файлов по формату

            // Открыть диалогове окно открытия файла
            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                // Открыть документ
                string filePath = dialog.FileName;
                string text = File.ReadAllText(filePath);
                Input_text.Text = text;
            }
        }

        private void save_file()
        {
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.FileName = "Document";                   // Стандартное имя файла
            dialog.DefaultExt = ".txt";                     // Стандартный формат файла
            dialog.Filter = "Text documents (.txt)|*.txt";  // Фильтрация файлов по формату

            // Открыть диалогове окно сохранения файла
            bool? result = dialog.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                string filePath = dialog.FileName;
                string text = Input_text.Text;
                char[] lineFeedChars = { '\n', '\r' };
                string[] cleanTextArray = text.Split(lineFeedChars, StringSplitOptions.RemoveEmptyEntries);
                string cleanText = string.Join(Environment.NewLine, cleanTextArray);
                File.WriteAllText(filePath, cleanText);
            }
        }

    }
}
