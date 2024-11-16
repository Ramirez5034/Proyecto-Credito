using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_credito
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Crear una instancia del formulario sin parámetros
            form1.Show(); // Mostrar el nuevo formulario
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(); // Crear una instancia del formulario sin parámetros
            inicio.Show(); // Mostrar el nuevo formulario
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Mostrar mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario selecciona "Sí", cerrar la aplicación
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAumento formaumento = new FormAumento(); // Crear una instancia del formulario sin parámetros
            formaumento.Show(); // Mostrar el nuevo formulario
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            carritoCompras carrito = new carritoCompras(); // Crear una instancia del formulario sin parámetros
            carrito.Show(); // Mostrar el nuevo formulario
            this.Hide();
        }
    }
}
