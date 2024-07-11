using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

            if (TxtUsuario.Text == "admin" && TxtContrasena.Text == "123")
            {

                for (int i = 0; i <= pbrInicio.Maximum; i++)
                {
                    pbrInicio.Value = i;
                    label2.Text = pbrInicio.Value.ToString() + "%";
                    Application.DoEvents();
                    Thread.Sleep(20); //Acelerar o retrasar una barra de progreso
                   

                }
               
                //Instancia del formilario 2
                Form2 conector = new Form2();
                conector.Show();

                this.Hide();//para que se cierre la ventana
                MessageBox.Show("¡Has iniciado sesion Correctamente!");

            }
            else
            {

                MessageBox.Show("¡Error! usuario o contraseña incorrecta.");
                TxtUsuario.Clear();
                TxtContrasena.Clear();

            }
        }
       
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            TxtUsuario.Clear();
            TxtContrasena.Clear();
            this.Hide();

        }

        private void PbOcultar_Click(object sender, EventArgs e)
        {

            //la imagen mostrar la mandamos adelante
            PbMostrar.BringToFront();

            //Mostramos la contraseña
            TxtContrasena.UseSystemPasswordChar = false; //Esta en false significa que esta desactivada y se mostrara 

        }

        private void PbMostrar_Click(object sender, EventArgs e)
        {

            //la imagen ocultar la mandamos adelante
            PbOcultar.BringToFront();

            //Mostramos la contraseña
            TxtContrasena.UseSystemPasswordChar = true; //Esta en true significa que esta activada y no se mostrara 

        }

    }
}

