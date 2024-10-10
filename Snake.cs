
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace ExtraSnake
{
    internal class Snake
    {
        private int tamano;
        private Direction direccion;
        private const int tamanoCelda = 20;
        private const int anchoTablero = 20;
        private const int alturaTablero = 20;
        private const int tamanoInicialSnake = 3;
        private List<Point> serpiente;// = new List<Point>();
        private PictureBox picture;
        private Form1 form1;


        Food food;// = new Food();
        Principal principal;// = new Principal();

        Thread hilo1;
      

        public Snake()
        {
        }

        public void setForm(Form1 form)
        {
            this.form1 = form;
        }

        public int tamanoCeld
        {
            get { return tamanoCelda; }

        }

        public int anchoTabler
        {
            get { return anchoTablero; }

        }
        public int alturaTabler
        {
            get { return alturaTablero; }

        }

        public int tamanoInicialSnak
        {
            get { return tamanoInicialSnake; }

        }

        public List<Point> listSerpiente { get { return serpiente; } set { serpiente = value; } }

        public PictureBox Picture { get => picture; set => picture = value; }




        public void generarSerpiente(Graphics g)
        {
            foreach (Point segment in serpiente)
            {
                g.FillRectangle(Brushes.Aqua, segment.X * tamanoCelda, segment.Y * tamanoCelda, tamanoCelda, tamanoCelda);
            }
        }

        public enum Direction { Down, Left, Right, Up };

        public void SetDirection(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    if (direccion != Direction.Down)
                        direccion = Direction.Up;
                    break;
                case Keys.Down:
                    if (direccion != Direction.Up)
                        direccion = Direction.Down;
                    break;
                case Keys.Left:
                    if (direccion != Direction.Right)
                        direccion = Direction.Left;
                    break;
                case Keys.Right:
                    if (direccion != Direction.Left)
                        direccion = Direction.Right;
                    break;
            }
        }



    public void moverSerpiente()
        {
            Point cabeza = serpiente[0];
            Point nuevaCabeza = new Point(cabeza.X, cabeza.Y);

            switch (direccion)
            {
                case Direction.Up:
                    nuevaCabeza.Y--;
                    break;
                case Direction.Down:
                    nuevaCabeza.Y++;
                    break;
                case Direction.Left:
                    nuevaCabeza.X--;
                    break;
                case Direction.Right:
                    nuevaCabeza.X++;
                    break;
            }

            serpiente.Insert(0, nuevaCabeza);

            if (nuevaCabeza == food.Comida)
            {
                food.generarComida(this);
                tamano++;
                form1.actualizarPuntos(tamano);
            }
            else
            {
                serpiente.RemoveAt(serpiente.Count - 1);


            }
        }


        public void jugarSnake(Form1 form, string dificultad)
        {
            
            food = new Food();
            direccion = Direction.Right;
            serpiente = new List<Point>();

            int startX = anchoTabler / 2;
            int startY = alturaTabler / 2;
            serpiente.Add(new Point(startX, startY));      
            serpiente.Add(new Point(startX - 1, startY));      
            serpiente.Add(new Point(startX - 2, startY));      
            food.generarComida(this);
           
            picture = new PictureBox();
            picture.Size = new Size(anchoTabler * tamanoCeld, alturaTabler * tamanoCeld);
            picture.Location = new Point(10, 10);
            picture.BackColor = Color.LightGreen;
            picture.Paint += pintarJuego;
            //Form1 form = new Form1();
            form.Controls.Add(picture);
            principal = new Principal(this);
            principal.cambiarVelocidad(dificultad);
            hilo1 = new Thread(principal.bucleJuego);
            hilo1.Start();


        }

        public void pintarJuego(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            generarSerpiente(g);
            food.dibujarComida(g, this);
        }

        public void abortarHilo()
        {
            hilo1.Abort();
        }
    }
}
