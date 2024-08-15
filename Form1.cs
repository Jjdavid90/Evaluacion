using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                var Nombre = txt_nombre_apellido.Text;
                var Correo = txt_correo.Text;
                var telefono = txt_telefono.Text;

                string cadena = Nombre + " || " + Correo + " || " + telefono;

                lstAgenda.Items.Add(cadena); // Agrega la variable 'cadena' que contiene el valor correcto
                LimpiarCajas();
            }

        }

        private void LimpiarCajas()
        {
            txt_nombre_apellido.Text = "";
            txt_correo.Text = "";
            txt_telefono.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstAgenda.SelectedIndex != -1)
            {
                lstAgenda.Items.RemoveAt(lstAgenda.SelectedIndex);
            }
            txt_nombre_apellido.Text = "";
            txt_correo.Text = "";
            txt_telefono.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstAgenda.SelectedIndex != -1)
            {
                lstAgenda.Items.RemoveAt(lstAgenda.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seleccione la t que desee eliminar");
            }

        }
    }
}
