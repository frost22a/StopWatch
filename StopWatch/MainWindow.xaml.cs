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
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            dispatcherTimer.Tick += stopWatchTick;
            dispatcherTimer.Start();
        }
                
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            stopWatch.Start();           
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                stopWatch.Stop();
            }
            
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            stopWatch.Reset();
        }

        private void stopWatchTick(object sender, EventArgs e)
        {
            timeSpan = stopWatch.Elapsed;
            string currentTime  = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds / 10);
            stopWatchView.Text = currentTime;
        }
    }
}
