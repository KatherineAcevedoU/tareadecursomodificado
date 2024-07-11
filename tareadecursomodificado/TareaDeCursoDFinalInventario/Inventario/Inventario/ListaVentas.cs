using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    public  class ListaVentas
    {

        //Atributos de la clase

        // creacion de una clase lista Ventas, esta clase se crea para representar una venta con sus atributos
        // 
        public string CodigoProductoVender {  get; set; }

        public string NombreProductovendido { get; set; }

        public double PrecioProductoVender { get; set; }

        public int cantidadProductoVender { get; set; }

        public double SubTotalVender { get; set; }

        public DateTime fecha {  get; set; }

    }
}
