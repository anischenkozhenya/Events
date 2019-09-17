using System;
using System.Windows;
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
        public DispatcherTimer dt;
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
            dt = new DispatcherTimer();
            dt.Interval=TimeSpan.FromMilliseconds(1);
            dt.Tick += Dt_Tick;
        }
                
        private EventHandler tick = null;
        private EventHandler startTimer = null;
        private EventHandler stopTimer = null;
        private EventHandler resetTimer = null;
        private void Dt_Tick(object sender, EventArgs e)
        {
            tick(sender, e);
        }
        public event EventHandler Tick
        {
            add { tick += value; }
            remove { tick -= value; }
        }
        public event EventHandler StartTimer
        {
            add { startTimer += value; }
            remove { startTimer -= value; }
        }
        public event EventHandler StopTimer
        {
            add { stopTimer += value; }
            remove { stopTimer -= value; }
        }
        public event EventHandler ResetTimer {
            add {resetTimer += value;}
            remove {resetTimer -= value;}
        }

        private void BtnStart_Click(object sender,EventArgs e)
        {
            startTimer(sender,e);
        }

        private void BtnStop_Click(object sender,EventArgs e)
        {
            stopTimer(sender, e);
        }

        private void BtnReset_Click(object sender,EventArgs e)
        {
            resetTimer(sender, e);
        }
    }
}
