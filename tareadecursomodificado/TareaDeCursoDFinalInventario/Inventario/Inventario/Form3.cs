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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventario
{
    public partial class Form3 : Form
    {

        private double precioProductoVenta;
        private string nombreProductoVender;
      
        // Es una lista de objetos de tipo "ListaVentas", la clase list es una coleccion generica que permite almacenar objetos 
        // en una lista 
        public static List<ListaVentas> listaVentas = new List<ListaVentas>();

        public Form3()
        {
            InitializeComponent();

            
            btnAgregarVenta.Enabled = false;
            btnCalcularVenta.Enabled = false;
            btnGenerarPago.Enabled = false;

            txtPrecio2.Enabled = false;
            txtCantidadVender.Enabled = false;
            txtSubTotal.Enabled = false;
            txtSubTotalFactura.Enabled = false;
            txtTotalFactura.Enabled = false;

            txtTotal.Enabled = false;
            txtCash.Enabled = false;
            groupBox1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            textBox3.Enabled = false;
            btnPagar.Enabled = false;
            btnFactura.Enabled = false;

        }

        private void btnVerificarVenta_Click(object sender, EventArgs e)
        {
            // Esta siguiente linea de codigo , se utiliza para verificar si una cadena de texto esta vacia o nula.
            // esto quiere decir que si el usurio no ha ingresado nada en el texbox llamado "txtCodigoVeri" le mandara 
            // un mensaje diciendole que debe ingresar algo en el textbox para poder buscar
            if ((String.IsNullOrEmpty(txtCodigoVeri.Text))  )
            {

                MessageBox.Show("Porfavor, ingrese la informacion del codigo a vender!");
                return;

            }
            else
            {

                // aqui declaramos una variable para asignarle el valor de un control de entrada de texto el cual es 
                // "TEXTBOX"
                string codigo = txtCodigoVeri.Text;


                //(p => p.CodigoProducto == codigo), esta es una expresion lambda que representa la condicion 
                // que se debe cumplir aqui p. es un parametro que representa cada elemento de la listaProducto y 
                //p.CodigoProducto == codigo, es la condicion que se evalua para cada elemento 
                var producto = Form2.listaProducto.FirstOrDefault(p => p.CodigoProducto == codigo);

                if (producto == null)
                {
                    btnAgregarVenta.Enabled = false;
                    txtPrecio2.Enabled = false;
                    txtCantidadVender.Enabled = false;
                    txtSubTotal.Enabled = false;
                    MessageBox.Show("Producto no encontrado!");

                    

                }
                else
                {

                    //Mandamos a llamar los datos del formulario 2
                    nombreProductoVender = producto.NombreProducto;
                    precioProductoVenta = producto.PrecioProducto;
                    txtNombreVendido.Text = producto.NombreProducto;
                    txtPrecio2.Text = producto.PrecioProducto.ToString();

                    MessageBox.Show($"¡Producto encontrado!  {producto.NombreProducto}");
                    btnAgregarVenta.Enabled = true;
                    txtPrecio2.Enabled = true;
                    txtCantidadVender.Enabled = true;
                    txtSubTotal.Enabled = true;

                }             

                

            }
        }


        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            int cantidad;
            double precio, subTotal;

            if ((string.IsNullOrEmpty(txtCantidadVender.Text)))
            {

                MessageBox.Show("Porfavor, ingrese la cantidad a vender!");
                return;

            }
            else
            {
                int cantidadProducto = int.Parse(txtCantidadVender.Text);

                var productoCantidad = Form2.listaProducto.FirstOrDefault(p => p.CantidadProducto >= cantidadProducto);

                if (productoCantidad != null)
                {

                    //Instanciamos la clase ListaVentas
                    ListaVentas mensajero = new ListaVentas();

                    //Colocamos la informacion
                    mensajero.CodigoProductoVender = txtCodigoVeri.Text;
                    mensajero.NombreProductovendido = txtNombreVendido.Text;
                    mensajero.PrecioProductoVender = double.Parse(txtPrecio2.Text);
                    mensajero.cantidadProductoVender = int.Parse(txtCantidadVender.Text);
                    mensajero.fecha = dtFechaVenta.Value;

                    //Guardamos los datos en las variables con las que realizamos la operacion
                    cantidad = Convert.ToInt32(txtCantidadVender.Text);
                    precio = Convert.ToDouble(txtPrecio2.Text);

                    //Calculo del subTotal
                    subTotal = cantidad * precio;

                    //Mostramos la operacion en el cuadrito
                    txtSubTotal.Text = subTotal.ToString();

                    mensajero.SubTotalVender = double.Parse(txtSubTotal.Text);

                    //Guardamos el objeto en la tabla 
                    listaVentas.Add(mensajero);

                    //Limpiamos la tabla 
                    dtgVentaProductos.DataSource = null;

                    // Pasar los datos de la lista a la tabla
                    dtgVentaProductos.DataSource = listaVentas;

                    btnCalcularVenta.Enabled = true;
                    btnGenerarPago.Enabled = false;

                }
                else
                {

                    MessageBox.Show("Esta cantidad no se encuentra disponible!");

                }
            }
        }
        
        private void btnCalcularVenta_Click(object sender, EventArgs e)
        {

            btnGenerarPago.Enabled = true;

            double SubTotalFactura = 0;
            double TotalFactura = 0;
            double impuesto;

            foreach(ListaVentas conector in listaVentas)
            {

                SubTotalFactura += conector.SubTotalVender;

            }

            //Calculamos el impuesto
            impuesto = SubTotalFactura * 0.15;

            //Sumamos el impuesto
            TotalFactura = SubTotalFactura + impuesto;

            txtSubTotalFactura.Text = SubTotalFactura.ToString();
            txtTotalFactura.Text = TotalFactura.ToString();

        }

        private void btnGenerarPago_Click(object sender, EventArgs e)
        {
            txtTotal.Enabled = true;
            txtTotalFactura.Enabled = true;
            txtCash.Enabled = true;
            groupBox1.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            textBox3.Enabled = true;
            btnPagar.Enabled = true;
            btnFactura.Enabled = true;

        }

        

        private void txtCantidadVender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodigoVeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

       

        private void button3_Click(object sender, EventArgs e)
        {

            StreamWriter escribir2 = new StreamWriter(@"C:\Users\Usuario\Desktop\ArchivosFacturas.txt", true);

            try
            {

                escribir2.WriteLine("");
                escribir2.WriteLine("            FACTURA DE VENTA               ");
                escribir2.WriteLine("Fecha: " + dtFechaVenta.Text);
                escribir2.WriteLine("");
                escribir2.WriteLine("--------------------------------------------");

                escribir2.WriteLine("Codigo del producto vendido:" + txtCodigoVeri.Text);
                escribir2.WriteLine("Nombre del producto:" + txtNombreVendido.Text);
                escribir2.WriteLine("Cantidad vendida: " + txtCantidadVender.Text);
                escribir2.WriteLine("Precio del producto:" + txtPrecio2.Text);
                escribir2.WriteLine("----------------------------------------------");
                escribir2.WriteLine("");
                escribir2.WriteLine("----------------------------------------------");
                escribir2.WriteLine("SubTotal: " + txtSubTotalFactura.Text);
                escribir2.WriteLine("Total (mas impuesto): " + txtTotalFactura.Text);
                escribir2.WriteLine("----------------------------------------------");
                escribir2.WriteLine("");
                escribir2.WriteLine("Efectivo Entregado: " + txtCash.Text);
                escribir2.WriteLine("Efectivo devuelto: " + textBox3.Text);
                escribir2.WriteLine("");
                escribir2.WriteLine("****************************************");
                escribir2.WriteLine("*       Gracias por su compra          *");
                escribir2.WriteLine("****************************************");
                escribir2.WriteLine("Factura generada exitosamente");


                MessageBox.Show("Factura agregada al archivo de texto exitosamente");
            }
            catch
            {

                MessageBox.Show("Error");

            }

            escribir2.Close();
            
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTotal.Text))
            {

                MessageBox.Show("Porfavor, ingrese el Total de la factura!");
                return;

            }
            else
            {

                if (string.IsNullOrEmpty(txtCash.Text))
                {

                    MessageBox.Show("Porfavor, ingrese la cantidad con la que pagara la factura!");
                    return;

                }
                else
                {
                    if (!radioButton1.Checked && !radioButton2.Checked)
                    {

                        MessageBox.Show("¡Error! ingrese el tipo de moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    else
                    {
                        double resultado;

                        resultado = Convert.ToDouble(txtCash.Text) - Convert.ToDouble(txtTotal.Text);
                        textBox3.Text = resultado.ToString();

                        


                            if (radioButton2.Checked == true)
                            {

                                double tipoCambio = 36.6;
                                label4.Text = "El tipo de cambio es: " + tipoCambio;
                                resultado = (Convert.ToDouble(txtCash.Text) * tipoCambio) - Convert.ToDouble(txtTotal.Text);
                                textBox3.Text = resultado.ToString();

                            }
                            else
                            {

                                resultado = (Convert.ToDouble(txtCash.Text) - Convert.ToDouble(txtTotal.Text));
                                textBox3.Text = resultado.ToString();

                            }
                        
                    }
                }
            }

           


        }

        //Validaciones

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }


        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

            txtCodigoVeri.Clear();
            txtNombreVendido.Clear();
            txtPrecio2.Clear();
            txtCantidadVender.Clear();
            txtSubTotal.Clear();

        }

        private void BtnRegistrarProducto_Click(object sender, EventArgs e)
        {

            //Instancia del formulario 2
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtgVentaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewColumn columna in dtgVentaProductos.Columns)
            {
                columna.ReadOnly = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
