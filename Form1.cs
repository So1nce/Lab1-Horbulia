using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1_Horbulia
{
    public partial class Lab1 : Form
    {
        CShape[] shapes;
        int ShapeCount = 0;
        int CurrentShapeIndex;

        public Lab1()
        {
            InitializeComponent();
            shapes = new CShape[100];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ShapeCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!");
                return;
            }

            Graphics graphics = pnMain.CreateGraphics();
            CurrentShapeIndex = ShapeCount;
            // Створення нового об'єкта - екземпляра класу 
            shapes[CurrentShapeIndex] =
            new CShape(graphics, pnMain.Width / 2,
            pnMain.Height / 2, 50);
            shapes[CurrentShapeIndex].Show();
            ShapeCount++;
            cbShape.Items.Add("Коло No" + (ShapeCount - 1).ToString());
            cbShape.SelectedIndex = ShapeCount - 1;
        }

        private void btnUpFar_Click(object sender, EventArgs e)
        {
            CurrentShapeIndex = cbShape.SelectedIndex;
            if ((CurrentShapeIndex > ShapeCount) || (CurrentShapeIndex < 0))
                return;
            // Переміщення поточного об'єкта вверх на більшу відстань
            for (int i = 0; i < 100; i++)
            {
                shapes[CurrentShapeIndex].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            CurrentShapeIndex = cbShape.SelectedIndex;
            if ((CurrentShapeIndex > ShapeCount) || (CurrentShapeIndex < 0))
                return;
            shapes[CurrentShapeIndex].Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            CurrentShapeIndex = cbShape.SelectedIndex;
            if ((CurrentShapeIndex > ShapeCount) || (CurrentShapeIndex < 0))
                return;
            // Відображення поточного об'єкта
            shapes[CurrentShapeIndex].Show();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            CurrentShapeIndex = cbShape.SelectedIndex;
            if ((CurrentShapeIndex > ShapeCount) || (CurrentShapeIndex < 0))
                return;
            shapes[CurrentShapeIndex].Expand(5);
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            CurrentShapeIndex = cbShape.SelectedIndex;
            if ((CurrentShapeIndex > ShapeCount) || (CurrentShapeIndex < 0))
                return;
            // Стискання поточного об'єкта - екземпляра класу CCircle
            shapes[CurrentShapeIndex].Collapse(5);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            CurrentShapeIndex = cbShape.SelectedIndex;
            if ((CurrentShapeIndex > ShapeCount) || (CurrentShapeIndex < 0))
                return;
            // Переміщення вверх поточного об'єкта
            shapes[CurrentShapeIndex].Move(0, -10);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            CurrentShapeIndex = cbShape.SelectedIndex;
            if ((CurrentShapeIndex > ShapeCount) || (CurrentShapeIndex < 0))
                return;
            // Переміщення вниз поточного об'єкта
            shapes[CurrentShapeIndex].Move(0, 10);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            CurrentShapeIndex = cbShape.SelectedIndex;
            if ((CurrentShapeIndex > ShapeCount) || (CurrentShapeIndex < 0))
                return;
            // Переміщення вправо поточного об'єкта
            shapes[CurrentShapeIndex].Move(10, 0);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            CurrentShapeIndex = cbShape.SelectedIndex;
            if ((CurrentShapeIndex > ShapeCount) || (CurrentShapeIndex < 0))
                return;
            // Переміщення вліво поточного об'єкта
            shapes[CurrentShapeIndex].Move(-10, 0);
        }

        private void btnRightFar_Click(object sender, EventArgs e)
        {
            CurrentShapeIndex = cbShape.SelectedIndex;
            if ((CurrentShapeIndex > ShapeCount) || (CurrentShapeIndex < 0))
                return;
            // Переміщення поточного об'єкта вправо на більшу відстань
            for (int i = 0; i < 100; i++)
            {
                shapes[CurrentShapeIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnLeftFar_Click(object sender, EventArgs e)
        {
            CurrentShapeIndex = cbShape.SelectedIndex;
            if ((CurrentShapeIndex > ShapeCount) || (CurrentShapeIndex < 0))
                return;
            // Переміщення поточного об'єкта вліво на більшу відстань
            for (int i = 0; i < 100; i++)
            {
                shapes[CurrentShapeIndex].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnDownFar_Click(object sender, EventArgs e)
        {
            CurrentShapeIndex = cbShape.SelectedIndex;
            if ((CurrentShapeIndex > ShapeCount) || (CurrentShapeIndex < 0))
                return;
            // Переміщення поточного об'єкта вниз на більшу відстань
            for (int i = 0; i < 100; i++)
            {
                shapes[CurrentShapeIndex].Move(0, 1);
                System.Threading.Thread.Sleep(5);
            }
        }
    }
}
