using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1_Horbulia
{
    public partial class Lab1 : Form
    {
        CEmblem[] emblems;
        int EmblemsCount = 0;
        int CurrentEmblemIndex;

        public Lab1()
        {
            InitializeComponent();
            emblems = new CEmblem[100];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (EmblemsCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!");
                return;
            }

            Graphics graphics = pnMain.CreateGraphics();
            CurrentEmblemIndex = EmblemsCount;
            // Створення нового об'єкта - екземпляра класу 
            emblems[CurrentEmblemIndex] =
            new CEmblem(graphics, pnMain.Width / 2,
            pnMain.Height / 2, 50);
            emblems[CurrentEmblemIndex].Show();
            EmblemsCount++;
            cbEmblem.Items.Add("Емблема No" + (EmblemsCount - 1).ToString());
            cbEmblem.SelectedIndex = EmblemsCount - 1;
        }

        private void btnUpFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblem.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0))
                return;
            // Переміщення поточного об'єкта вверх на більшу відстань
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblem.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblem.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0))
                return;
            // Відображення поточного об'єкта
            emblems[CurrentEmblemIndex].Show();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblem.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Expand(5);
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblem.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0))
                return;
            // Стискання поточного об'єкта - екземпляра класу CCircle
            emblems[CurrentEmblemIndex].Collapse(5);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblem.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0))
                return;
            // Переміщення вверх поточного об'єкта
            emblems[CurrentEmblemIndex].Move(0, -10);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblem.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0))
                return;
            // Переміщення вниз поточного об'єкта
            emblems[CurrentEmblemIndex].Move(0, 10);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblem.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0))
                return;
            // Переміщення вправо поточного об'єкта
            emblems[CurrentEmblemIndex].Move(10, 0);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblem.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0))
                return;
            // Переміщення вліво поточного об'єкта
            emblems[CurrentEmblemIndex].Move(-10, 0);
        }

        private void btnRightFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblem.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0))
                return;
            // Переміщення поточного об'єкта вправо на більшу відстань
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnLeftFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblem.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0))
                return;
            // Переміщення поточного об'єкта вліво на більшу відстань
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnDownFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblem.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemsCount) || (CurrentEmblemIndex < 0))
                return;
            // Переміщення поточного об'єкта вниз на більшу відстань
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(0, 1);
                System.Threading.Thread.Sleep(5);
            }
        }
    }
}
