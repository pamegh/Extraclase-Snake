using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraSnake
{
    internal class Food
    {
        Point comida;

        public Point Comida { get => comida; set => comida = value; }

        public void dibujarComida(Graphics g, Snake snake)
        {
            g.FillRectangle(Brushes.Red, comida.X * snake.tamanoCeld, comida.Y * snake.tamanoCeld, snake.tamanoCeld, snake.tamanoCeld);
        }
        public void generarComida(Snake snake)
        {
            Random random = new Random();
            comida = new Point(random.Next(snake.anchoTabler), random.Next(snake.alturaTabler));
        }
    }
}
