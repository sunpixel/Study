using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace VideoPlayer
{
    public partial class MainWindow : Window
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        private List<string> playlist = new List<string>();
        private int currentVideoIndex = 0;

        public MainWindow()
        {
            InitializeComponent();

            mediaPlayer.MediaEnded += MediaPlayer_MediaEnded;
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (playlist.Count > 0)
            {
                if (mediaPlayer.Source == null)
                {
                    mediaPlayer.Open(new Uri(playlist[currentVideoIndex]));
                }

                mediaPlayer.Play();
            }
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
            mediaPlayer.Close();
        }

        private void AddFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Video Files (*.mp3, *.wav)|*.wav;*.mp3";

            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    playlist.Add(fileName);
                    ListBoxItem item = new ListBoxItem();
                    item.Content = Path.GetFileName(fileName);
                    PlaylistListBox.Items.Add(item);
                }
            }
        }

        private void SavePlaylistButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Playlist Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == true)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (string fileName in playlist)
                    {
                        writer.WriteLine(fileName);
                    }
                }
            }
        }

        private void OpenPlaylistButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Playlist Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == true)
            {
                ClearPlaylist();
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        playlist.Add(line);
                        ListBoxItem item = new ListBoxItem();
                        item.Content = Path.GetFileName(line);
                        PlaylistListBox.Items.Add(item);
                    }
                }
            }
        }

        private void ClearPlaylistButton_Click(object sender, RoutedEventArgs e)
        {
            ClearPlaylist();
        }

        private void ClearPlaylist()
        {
            playlist.Clear();
            PlaylistListBox.Items.Clear();
            currentVideoIndex = 0;
            mediaPlayer.Stop();
            mediaPlayer.Close();
        }

        private void PlaylistListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PlaylistListBox.SelectedIndex >= 0)
            {
                currentVideoIndex = PlaylistListBox.SelectedIndex;
                mediaPlayer.Open(new Uri(playlist[currentVideoIndex]));
                mediaPlayer.Play();
            }
        }

        private void MediaPlayer_MediaEnded(object sender, EventArgs e)
        {
            currentVideoIndex++;
            if (currentVideoIndex < playlist.Count)
            {
                mediaPlayer.Open(new Uri(playlist[currentVideoIndex]));
                mediaPlayer.Play();
            }
            else
            {
                currentVideoIndex = 0;
                mediaPlayer.Stop();
            }
        }
    }
}
