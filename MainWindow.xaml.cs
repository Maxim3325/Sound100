using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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
using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            LoadData();
            Sound100();
        }

        private void LoadData()
        {
            
            while(true)
            {
                AudioFileReader reader;
                WaveOutEvent outputDevice;

                var devEnumerator = new MMDeviceEnumerator();
                var dev = devEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

                dev.AudioEndpointVolume.Mute = false;
                dev.AudioEndpointVolume.MasterVolumeLevelScalar = 1f;

                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = System.IO.Path.Combine(basePath, "5869621187113387680.mp3");

                MediaPlayer mediaPlayer = new MediaPlayer();
                mediaPlayer.Open(new Uri(filePath));
                mediaPlayer.Play();

                Thread.Sleep(5100);


            }
            
        }

        private void Sound100()
        {
            while (true)
            {
                var devEnumerator = new MMDeviceEnumerator();
                var dev = devEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

                dev.AudioEndpointVolume.Mute = false;
                dev.AudioEndpointVolume.MasterVolumeLevelScalar = 1f;
            }
        }
    }
}
