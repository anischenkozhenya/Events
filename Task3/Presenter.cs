using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Presenter
    {
        MainWindow mainWindow = null;
        Model model = null;
        public Presenter(MainWindow mW)
        {
            model = new Model();
            this.mainWindow = mW;            
            mainWindow.SumEvent += BtnSum_Click;
            mainWindow.SubEvent += BtnSub_Click;
            mainWindow.MulEvent += BtnMul_Click;
            mainWindow.DivEvent += BtnDiv_Click;
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            this.mainWindow.ResTextBox.Text =
                model.Div(Convert.ToInt32(mainWindow.XTextBox.Text),
                Convert.ToInt32(this.mainWindow.YTextBox.Text)).ToString();
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            this.mainWindow.ResTextBox.Text =
                model.Mul(Convert.ToInt32(this.mainWindow.XTextBox.Text),
                Convert.ToInt32(this.mainWindow.YTextBox.Text)).ToString();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            this.mainWindow.ResTextBox.Text =
                model.Sub(Convert.ToInt32(this.mainWindow.XTextBox.Text),
                Convert.ToInt32(this.mainWindow.YTextBox.Text)).ToString();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            this.mainWindow.ResTextBox.Text =
                model.Sum(Convert.ToInt32(this.mainWindow.XTextBox.Text),
                Convert.ToInt32(this.mainWindow.YTextBox.Text)).ToString();
        }
    }
}
