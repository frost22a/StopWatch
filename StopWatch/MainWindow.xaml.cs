using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace StopWatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Stopwatch stopWatch = new Stopwatch();
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        TimeSpan timeSpan;
        public MainWindow()
        {
            InitializeComponent();                         
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            stopWatch.Start();
            timeSpan = stopWatch.Elapsed;
            stopWatchView.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds / 10);
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                stopWatch.Stop();
            }
            
        }

        private void btnStart_Copy1_Click(object sender, RoutedEventArgs e)
        {
            stopWatch.Reset();
        }
    }
}
