using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraSnake
{
    public partial class Inicio : Form
    {
        private Principal principal;
        private Snake snake;
        public Inicio()
        {

            InitializeComponent();
            principal = new Principal();
            comboNiveles.SelectedItem = "MEDIO";
            bDificultad.Enabled = false;

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(comboNiveles.SelectedItem.ToString());
            this.Visible = false;
            form.Visible = true;
        }


        private void label1_BackColorChanged(object sender, EventArgs e)
        {
        }

        private void comboNiveles_SelectedIndexChanged(object sender, EventArgs e)
        {

            string seleccion = comboNiveles.SelectedItem.ToString();
            principal.cambiarVelocidad(seleccion);
        }
        }
    }

