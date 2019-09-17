using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;
        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            model = new Model();
            this.mainWindow.MyEvent += MainWindow_MyEvent;
        }
        private void MainWindow_MyEvent(object sender, EventArgs e)
        {
            this.mainWindow.TBMain.Text = model.MyMethod(this.mainWindow.TBMain.Text);
        }
    }
}
