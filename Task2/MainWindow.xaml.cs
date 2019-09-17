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
using System.Windows.Threading;
//using System.Windows.Shapes;
//Используя Visual Studio, создайте проект по шаблону WPF Application.
//Создайте программу секундомер. Требуется выводить показания секундомера в окне. Окно имеет
//кнопки запуска, останова и сброса секундомера. Для реализации секундомера используйте паттерн MVP. 
namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dp;
        public MainWindow()
        {
            InitializeComponent();
            dp = new DispatcherTimer();
        }
        private EventHandler startTimer = null;
        public event EventHandler StartTimer
            {
            add { startTimer += value; }
            remove { startTimer -= value; }
            }
        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            startTimer(sender,e);
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
