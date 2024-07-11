using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Form2 : Form
    {
        
        //Creacion de una lista
        public static List<ListaDeProductos> listaProducto = new List<ListaDeProductos>();

        public Form2()
        {
            InitializeComponent();

              //Inicializando los botones para que no tengan accceso
              BtnConsultar.Enabled = false;
              BtnEliminar.Enabled = false;
              btnmodificar.Enabled = false;
              TxtNuevoCodigo.Enabled = false;
              label6.Enabled = false;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

            if ((String.IsNullOrEmpty(TxtCodigo.Text)) || (String.IsNullOrEmpty(TxtNombre.Text)) || (String.IsNullOrEmpty(TxtCantidad.Text)) || (String.IsNullOrEmpty(TxtPrecio.Text)) || (String.IsNullOrEmpty(CbxCategoria.Text)))
            {

                MessageBox.Show("Porfavor, ingrese la informacion!");

            }
            else
            {

                //Instancia de la clase 
                ListaDeProductos mensajero = new ListaDeProductos();

                //Creamos el objeto de la lista
                mensajero.CodigoProducto = TxtCodigo.Text;
                mensajero.NombreProducto = TxtNombre.Text;
                mensajero.CantidadProducto = int.Parse(TxtCantidad.Text); //Convierte un numero entero en forma de cadena
                mensajero.PrecioProducto = double.Parse(TxtPrecio.Text);  //Convierte un numero decimal en forma de cadena
                mensajero.CategoriaProducto = CbxCategoria.SelectedItem.ToString();

                //Guardamos el objeto a la lista
                listaProducto.Add(mensajero);

                //Limpiamos la tabla
                dataGridView1.DataSource = null;

                //Pasamos los datos de la lista a la tabla
                dataGridView1.DataSource = listaProducto;

                //Activamos el boton consultar
                BtnConsultar.Enabled = true;

            }
        }

        //Validaciones

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtCantidad_keyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtPrecio_keypress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtCodigo_keypress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtCantidad.Clear();
            TxtPrecio.Clear();
            TxtNuevoCodigo.Clear();
            CbxCategoria.SelectedIndex = 0;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            //Instancia del formulario 3
            Form3 f3 = new Form3();
            //para que se cierre la ventana
            this.Hide();
            f3.Show();

        }

        private void btnGuardarEnArchivo_Click(object sender, EventArgs e)
        {
            
            StreamWriter escribir = new StreamWriter(@"C:\Users\Usuario\Desktop\ArchivosProductos.txt", true);

            try
            {
                escribir.WriteLine("");
                escribir.WriteLine("---        REGISTRO DE PRODUCTOS          ---");
                escribir.WriteLine("---------------------------------------------");
                escribir.WriteLine(":::   CODIGO: " + TxtCodigo.Text);
                escribir.WriteLine(":::   NOMBRE: " + TxtNombre.Text);
                escribir.WriteLine(":::   CANTIDAD: " + TxtCantidad.Text);
                escribir.WriteLine(":::   PRECIO: " + TxtPrecio.Text);
                escribir.WriteLine(":::   CATEGORIA: " + CbxCategoria.Text);
                escribir.WriteLine("---------------------------------------------");

                MessageBox.Show("Producto agregado al archivo de texto exitosamente");

            }
            catch
            {

                MessageBox.Show("Error!");

            }

            escribir.Close();

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

            if ((String.IsNullOrEmpty(TxtCodigo.Text)))
            {

                MessageBox.Show("Porfavor, ingrese el codigo del producto a consultar!");
                return;

            }
            else
            {

                ListaDeProductos conector = GetProducto(TxtCodigo.Text);

                if (conector == null) //Por si no se encuentra un codigo buscado en la lista
                {

                    MessageBox.Show("El producto no esta registrado!");
                    return;

                }
                else
                {

                    //Enviamos a los textbox las informaciones de la clase
                    TxtCodigo.Text = conector.CodigoProducto;
                    TxtNombre.Text = conector.NombreProducto;
                    TxtCantidad.Text = conector.CantidadProducto.ToString();
                    TxtPrecio.Text = conector.PrecioProducto.ToString();
                    CbxCategoria.SelectedItem = conector.CategoriaProducto;

                    //Activamos el boton eliminar
                    BtnEliminar.Enabled = true;
                    btnmodificar.Enabled = true;
                    TxtNuevoCodigo.Enabled = true;
                    label6.Enabled = true;

                }
            }

        }

        //Metodo de obtener o consultar un producto
        private ListaDeProductos GetProducto(string codigo)
        {

            return listaProducto.Find(producto => producto.CodigoProducto.Contains(codigo));
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if ((String.IsNullOrEmpty(TxtCodigo.Text)))  //Verificado que el cuadro de texto del codigo este vacio
            {

                MessageBox.Show("Debe consultar el codigo del producto a eliminar!");

                //Desactivamos el boton eliminar
                BtnEliminar.Enabled = false;

                return;

            }
            else
            {
                //Guardamos la desicion del usuario con ayuda de un mensaje en una variable.
                DialogResult respuesta = MessageBox.Show("¿Esta seguro de eliminar este producto?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {

                    //Verifica que la lista esta vacia
                    //Contar si hay producto en la lista
                    if (listaProducto.Count == 0)
                    {

                        MessageBox.Show("No hay productos para eliminar!");
                        return;
                    }
                    else
                    {

                        ListaDeProductos productoEliminar = listaProducto.FirstOrDefault(p => p.CodigoProducto == TxtCodigo.Text);
                        //FirstOrDefault es un metodo para buscar 
                        //el primer elemento que coincida con el codigo buscado
                        //especificado en (TxtCodigo.Text)

                        if (productoEliminar == null)
                        {

                            MessageBox.Show("El producto con el codigo no fue encontrado!");
                            return;

                        }
                        else
                        {
                            // Remove para eliliminar informacion que esta con el codigo
                            listaProducto.Remove(productoEliminar);

                            //Limpiamos la tabla
                            dataGridView1.DataSource = null;

                            //Actualizamo los datos de la lista a la tabla
                            dataGridView1.DataSource = listaProducto;

                        }
                    }
                }
            }

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

            // Verifica si el campo esta vacio
            if (string.IsNullOrEmpty(TxtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar el código del producto a modificar.");
                return;
            }
            // si txt cotiene un valor intenta enci¿ontrar un producto
            ListaDeProductos productoAModificar = listaProducto.FirstOrDefault(p => p.CodigoProducto == TxtCodigo.Text);
            // si encuentra el producto lo actualiza
            if (productoAModificar != null)
            {
                // Modificar los datos del producto
                productoAModificar.NombreProducto = TxtNombre.Text;
                productoAModificar.CantidadProducto = Convert.ToInt32(TxtCantidad.Text);
                productoAModificar.PrecioProducto = Convert.ToDouble(TxtPrecio.Text);
                productoAModificar.CategoriaProducto = CbxCategoria.SelectedItem.ToString();

                // Verificar si se ingresó un nuevo código
                if (!string.IsNullOrEmpty(TxtNuevoCodigo.Text))
                {
                    // Cambiar el código del producto
                    productoAModificar.CodigoProducto = TxtNuevoCodigo.Text;
                }

                // Actualizar el DataGridView después de la modificación
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaProducto;

                MessageBox.Show("Producto modificado correctamente.");
            }
            else
            {
                MessageBox.Show("El producto con el código especificado no fue encontrado en la lista.");
            }
            // si no encuentra el producto manda de error

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // recorre cada columna del datagridview
            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {
                // establece la propiedad
                //Esto significa que no se puede editar directamente
                columna.ReadOnly = true;
            }
        }
    }
     
}
