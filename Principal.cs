using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraSnake
{
    internal class Principal
    {
        private Boolean jugando= true;
        private int velocidad = 300;
private Thread iniciar;
        private int puntos = 0;
        Snake snake;


        public int Puntos { get => puntos; set => velocidad = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }

        public Principal() { }

        public Principal(Snake snake) { this.snake = snake; }


        public void Choque()
        {
            List<Point> serpiente = snake.listSerpiente;
            Point cabeza = serpiente[0];

            if (cabeza.X < 0 || cabeza.X >= snake.anchoTabler || cabeza.Y < 0 || cabeza.Y >= snake.alturaTabler)
            {
                jugando = false;
                

                MessageBox.Show("Perdiste");
                snake.abortarHilo();
                
                return;
            }
            for (int i = 1; i < serpiente.Count; i++)
            {
                if (cabeza == serpiente[i])
                {
                    jugando = false;
                    
                    MessageBox.Show("Perdiste");
                    snake.abortarHilo();
                    return ;
                }
            }
        }

        public void cambiarVelocidad(string seleccion)
        {
            switch (seleccion)
            {
                case "FACIL":
                    Velocidad = 1000; 
                    break;
                case "MEDIO":
                    Velocidad = 300; 
                    break;
                case "DIFICIL":
                    Velocidad = 100; 
                    break;
                default:
                    velocidad = 300; 
                    break;
            }
        }

        public void configuracion() { 

}

        public void bucleJuego()
        {
            while (jugando)
            {  
                snake.moverSerpiente();
                Choque();
                snake.Picture.Invalidate();
                Thread.Sleep(Velocidad);
            }
        }

        

    }
}
