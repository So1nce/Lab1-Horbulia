using Lab1_Horbulia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Horbulia
{
    internal class CShape
    {
        const int DefaultRadius = 50;
        
        private Graphics graphics;
        private int _radius;
        public int X { get; set; } // Координата X центра кола
        public int Y { get; set; } // Координата Y центра кола
        public int Radius
        { // Радіус кола
            get
            {
                return _radius;
            }
            set
            {
                _radius = value >= 200 ? 200 : value;
                _radius = value <= 5 ? 5 : value;
            }
        }
        


        public CShape(Graphics graphics, int X, int Y)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = DefaultRadius;
        }

        public CShape(Graphics graphics, int X, int Y, int Radius)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
        }

        private void Draw(Pen pen)
        {
            
            Rectangle rectangle = new Rectangle(X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            graphics.DrawEllipse(pen, rectangle);
            graphics.DrawRectangle(pen, rectangle);

            int squareSize = (int)(Math.Sqrt(2) * Radius); // Диагональ квадрата равна диаметру круга
            int squareX = X - squareSize / 2;
            int squareY = Y - squareSize / 2;
            Rectangle rectangle2 = new Rectangle(squareX, squareY, squareSize, squareSize);
            graphics.DrawRectangle(pen, rectangle2);
        }


        public void Show()
        {
            Draw(Pens.Red);
        }
        // Приховує коло (малює на поверхні малювання GDI+ кольором фону)
        public void Hide()
        {
            Draw(Pens.White);
        }

        public void Expand()
        {
            Hide();
            Radius++;
            Show();
        }

        public void Expand(int dR)
        {
            Hide();
            Radius = Radius + dR;
            Show();
        }

        public void Collapse()
        {
            Hide();
            Radius--;
            Show();
        }

        public void Collapse(int dR)
        {
            Hide();
            Radius = Radius - dR;
            Show();
        }

        public void Move(int dX, int dY)
        {
            Hide();
            X = X + dX;
            Y = Y + dY;
            Show();
        }

    }  
}
