using System;
using System.Windows;
//Используя Visual Studio, создайте проект по шаблону WPF Application.
//Создайте калькулятор на четыре арифметических действия (сложение, вычитание, умножение и
//деление). Для реализации калькулятора используйте паттерн MVP.
namespace Task3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            sumEvent.Invoke(sender,e);
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            subEvent.Invoke(sender, e);
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            mulEvent.Invoke(sender, e);
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            divEvent.Invoke(sender,e);
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private EventHandler sumEvent = null;
        private EventHandler subEvent = null;
        private EventHandler mulEvent = null;
        private EventHandler divEvent = null;

        public event EventHandler SumEvent
        {
            add { sumEvent += value; }
            remove { sumEvent -= value; }
        }

        public event EventHandler SubEvent
        {
            add { subEvent += value; }
            remove { subEvent -= value; }
        }

        public event EventHandler MulEvent
        {
            add { mulEvent += value; }
            remove { mulEvent -= value; }
        }

        public event EventHandler DivEvent
        {
            add { divEvent += value; }
            remove { divEvent -= value; }
        }
    }
}
