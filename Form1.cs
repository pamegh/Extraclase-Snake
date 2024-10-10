using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ExtraSnake.Snake;

namespace ExtraSnake
{
    public partial class Form1 : Form
    {
        Boolean jugando;
        Snake snake;
        //String dificultad;

        public Form1()
        {
            InitializeComponent();
            //snake.jugarSnake(this);
       
        }

        public Form1(String dificultad)
        {
            InitializeComponent();
            snake = new Snake();
            snake.setForm(this);
            snake.jugarSnake(this, dificultad);
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            snake.SetDirection(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void actualizarPuntos(int puntos)
        {
            labelPuntos.Text = "Puntos: " + puntos.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelPuntos_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            snake.abortarHilo();
            Inicio inicio = new Inicio();
            this.Visible = false;
            inicio.Visible = true;
        }
    }
}
