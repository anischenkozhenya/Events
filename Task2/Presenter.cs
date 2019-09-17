using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   
    class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;
        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            this.mainWindow = mainWindow;
            mainWindow.StartTimer += MainWindow_StartTimer;
            mainWindow.StopTimer += MainWindow_StopTimer;
            mainWindow.ResetTimer += MainWindow_ResetTimer;
            mainWindow.Tick += MainWindow_Tick;
        }

        private void MainWindow_Tick(object sender, EventArgs e)
        {
            mainWindow.TimeLabel.Content = model.Tick();
        }

        private void MainWindow_ResetTimer(object sender, EventArgs e)
        {
            model.Reset();
            mainWindow.TimeLabel.Content = 0;
            mainWindow.dt.Stop();
        }

        private void MainWindow_StopTimer(object sender, EventArgs e)
        {
            mainWindow.dt.Stop();
        }

        private void MainWindow_StartTimer(object sender, EventArgs e)
        {
            mainWindow.dt.Start();
        }
    }
}
