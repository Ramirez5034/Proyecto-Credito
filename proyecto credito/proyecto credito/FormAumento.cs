using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace proyecto_credito
{
    public partial class FormAumento : Form
    {
        public FormAumento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF Files|*.pdf|All Files|*.*",
                Title = "Seleccione el comprobante de domicilio"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               
                string selectedfile = openFileDialog.FileName;
                string fileextension = Path.GetExtension(selectedfile).ToLower();

                if (fileextension == ".pdf")
                {
                    textBox1.Text = Path.GetFileName(openFileDialog.FileName);

                }
                else
                {
                    MessageBox.Show("seleccione un archivo imagen valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Imagenes|*.jpg;*.jpeg;*.png|All Files|*.*",
                Title = "Seleccione su imagen (INE o fotografía)"


            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                

                try
                {
                    using (var image = Image.FromFile(openFileDialog.FileName))
                    {
                        textBox2.Text = Path.GetFileName(openFileDialog.FileName);
                        pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    
                }

                catch (OutOfMemoryException)
                {
                    MessageBox.Show("seleccione un archivo imagen valido","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Por favor, cargue ambos archivos: el comprobante de domicilio y la imagen de INE o fotografía.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                MessageBox.Show("Solicitud de aumento de crédito enviada exitosamente. Espere nuestra confirmación.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu menuForm = new menu();
            menuForm.Show();


            this.Hide();
        }
    }
}

