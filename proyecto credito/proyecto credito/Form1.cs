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
    public partial class Form1 : Form
    {

        private List<(string Username, string Password)> registrar = new List<(string, string)>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            bool loginSuccessful = registrar.Exists(user => user.Username == username && user.Password == password);

            if (loginSuccessful)
            {
                MessageBox.Show("Login exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                menu MenuForm = new menu();
                MenuForm.Show();

               
                this.Hide(); 
               
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(registrar);
            registro.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
