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

namespace Multithreading_med_Tasks_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int number = 0;
        public int answer = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_Click_end(object sender, RoutedEventArgs e)
        {
            answer = Convert.ToInt32(Input.GetLineText(0));
            
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void button_Click_start(object sender, RoutedEventArgs e)
        {
            TimerText.Clear();
            Task task = textBox_Input();
        }
        public async Task textBox_Input()
        {

            number = NumberGenerator();
            TimerText.Clear();
            
            await GameCounter(TimerText);
            if (answer != 0)
            {
                GameCounter(TimerText).Dispose();
                if (answer == number)
                {
                    TimerText.Clear();
                    TimerText.AppendText("YOU WIN!");

                }

            }
        }

        async Task GameCounter(TextBox j)
        {
            for (int i = 0; i < 11; i++)
            {
                if (i == 10)
                {
                    j.AppendText("Looser!");
                }
                else
                {
                string a = "You have " + Convert.ToString(10 - i) + " seconds left";
                j.AppendText(a);
                await Task.Delay(1000);
                j.AppendText(Environment.NewLine);

                }
            }
        }

        private static int NumberGenerator()
        {

            Random random = new Random();
            int x = random.Next(1, 10);
            return x;
        }


    }
}
