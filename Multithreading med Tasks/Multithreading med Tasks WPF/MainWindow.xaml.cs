using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Threading;

namespace Multithreading_med_Tasks_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        CancellationTokenSource cts;
        public int number = 0;
        public int answer = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        public void button_Click_end(object sender, RoutedEventArgs e)
        {
            //Token to stop
            if (cts != null && number == answer)
            {
                cts.Cancel();
                cts.Dispose();
                cts = null;
                TimerText.AppendText(Environment.NewLine);
                TimerText.AppendText("YOU WIN!");
                timer.Interval = TimeSpan.FromMilliseconds(200);
                timer.Tick += new EventHandler(OnTick);
                timer.Start();

            }
            else
            {
                TimerText.AppendText(Environment.NewLine);
                TimerText.AppendText("Try Again!");
            }
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                answer = Convert.ToInt32(Input.Text.ToString());
            }
            catch (Exception)
            {
                TimerText.AppendText(Environment.NewLine);
                TimerText.AppendText("Wrong Input!");
            }
        }

        private async void button_Click_start(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            textBox_Input();
            //Token to start
            if (cts == null)
            {
                cts = new CancellationTokenSource();
                try
                {
                    await GameCounter(TimerText, cts.Token);
                }
                catch (OperationCanceledException)
                {
                }
            }
        }
        public void textBox_Input()
        {

            number = NumberGenerator();
            TimerText.Clear();

        }

        async Task GameCounter(TextBox j, CancellationToken token)
        {
            int i = 0;
            while (i != 11)
            {
                token.ThrowIfCancellationRequested();
                string a = "You have " + Convert.ToString(10 - i) + " seconds left: " + Convert.ToString(number);
                j.AppendText(a);
                await Task.Delay(1000, token);
                j.AppendText(Environment.NewLine);
                i++;
                if(i == 11)
                {
                    j.AppendText("Looser!");
                    await Task.Delay(2000, token);
                }
            }
        }

        private static int NumberGenerator()
        {

            Random random = new Random();
            int x = random.Next(1, 10);
            return x;
        }
        private bool BlinkOn;
        private void OnTick(object source, EventArgs e)
        {
            if (BlinkOn)
            {
                MainScreen.Background = Brushes.Green;
            }
            else
            {
                MainScreen.Background = Brushes.Blue;
            }
            BlinkOn = !BlinkOn;
        }
    }
}
