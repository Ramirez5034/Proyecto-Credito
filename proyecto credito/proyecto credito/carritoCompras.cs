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
    public partial class carritoCompras : Form
    {
        // Diccionario para llevar el conteo de los productos
        private Dictionary<string, int> carrito = new Dictionary<string, int>();

        public carritoCompras()
        {
            InitializeComponent();
            // Configuración inicial del ListView
            listViewCarrito.View = View.Details; // Modo de detalles
            listViewCarrito.Columns.Add("Producto", 150);
            listViewCarrito.Columns.Add("Cantidad", 70);
        }

        private void AgregarProductoAlCarrito(string nombreProducto)
        {
            // Verificar si el producto ya está en el carrito
            if (carrito.ContainsKey(nombreProducto))
            {
                carrito[nombreProducto]++; // Incrementar cantidad
            }
            else
            {
                carrito[nombreProducto] = 1; // Agregar nuevo producto
            }

            // Actualizar el ListView
            ActualizarListView();
        }

        private void ActualizarListView()
        {
            listViewCarrito.Items.Clear(); // Limpiar lista para actualizar
            foreach (var item in carrito)
            {
                // Agregar cada producto y su cantidad al ListView
                var listItem = new ListViewItem(item.Key); // Nombre del producto
                listItem.SubItems.Add(item.Value.ToString()); // Cantidad
                listViewCarrito.Items.Add(listItem);
            }
        }

        private void EliminarProductoSeleccionado()
        {
            if (listViewCarrito.SelectedItems.Count > 0)
            {
                string productoSeleccionado = listViewCarrito.SelectedItems[0].Text; // Obtener el nombre del producto
                carrito.Remove(productoSeleccionado); // Eliminar del diccionario
                ActualizarListView(); // Actualizar la lista
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ReducirCantidadProducto()
        {
            if (listViewCarrito.SelectedItems.Count > 0)
            {
                string productoSeleccionado = listViewCarrito.SelectedItems[0].Text;
                if (carrito.ContainsKey(productoSeleccionado))
                {
                    carrito[productoSeleccionado]--; // Reducir cantidad
                    if (carrito[productoSeleccionado] <= 0)
                    {
                        carrito.Remove(productoSeleccionado); // Eliminar si cantidad es 0
                    }
                    ActualizarListView(); // Actualizar el ListView
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto para reducir su cantidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BorrarTodoElCarrito()
        {
            carrito.Clear(); // Limpiar el diccionario
            ActualizarListView(); // Actualizar el ListView
        }


        private void btn_Menu_Click(object sender, EventArgs e)
        {
            menu menuForm = new menu();
            menuForm.Show();


            this.Hide();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Inicio inicioForm = new Inicio();
            inicioForm.Show();


            this.Hide();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El producto se a agregado.", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El producto se a eliminado.", "Producto Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_Vaciar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todos los productos se han eliminado.", "Carrito Vaciado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La compra se a procesado con exito.", "Compra Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void carritoCompras_Load(object sender, EventArgs e)
        {

        }

        private void buttonProducto1_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Consola Steam Valve");

        }

        private void buttonProducto2_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Game boy Advance");

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarProductoSeleccionado();

        }

        private void buttonBorrarTodo_Click(object sender, EventArgs e)
        {
            BorrarTodoElCarrito();

        }

        private void buttonReducirCantidad_Click(object sender, EventArgs e)
        {
            ReducirCantidadProducto();

        }

        private void ButtonProducto5_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Consola PlayStation 5");

        }

        private void buttonProducto3_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Consola GameCube");

        }

        private void buttonProducto4_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Nintendo Switch");

        }

        private void buttonProducto6_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Consola Xbox One");

        }
    }
}
