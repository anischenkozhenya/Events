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
using System.Windows.Shapes;
//Реализовать паттерн MVP, добавьте метод доступа
//add и remove к событию
namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Presenter presenter = null;
        public EventHandler MyEvent = null;
        public event EventHandler MyEvemt
        {
            add { MyEvent += value; }
            remove { MyEvent -= value; }
        }
        public MainWindow()
        {
            InitializeComponent();
            presenter = new Presenter(this);
        }  
        private void BtnDoSomething_Click(object sender, RoutedEventArgs e)
        {
            this.MyEvent(sender, e);
        }        
    }
}
