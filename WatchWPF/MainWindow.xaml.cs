using System;
using System.Diagnostics;
using System.Timers;
using System.Windows;
using System.Windows.Threading;

namespace WatchWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    // WPF Xaml
    public partial class MainWindow : Window
    {
        DispatcherTimer _timer;
        TimeSpan _time;
        public MainWindow()
        {
            InitializeComponent();

            _time = TimeSpan.FromSeconds(100);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) _timer.Stop();
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            _timer.Start();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
        }

        private void SetTimer_Click(object sender, RoutedEventArgs e)
        {
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            Boxed.Text = number.ToString();
        }
    }
}
