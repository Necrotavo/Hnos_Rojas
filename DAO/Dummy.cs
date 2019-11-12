using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;

namespace DAO
{
    public class Dummy
    {

        private List<DO_Producto> lista_Productos = new List<DO_Producto>();

        public Dummy()
        {
            lista_Productos.Add(new DO_Producto("1", 750, 1000, 1, "Leche", 3));
            lista_Productos.Add(new DO_Producto("2", 100, 250, 1, "Tang", 10));
            lista_Productos.Add(new DO_Producto("3", 500, 850, 1, "Mantequilla", 5));
        }


        public DO_Producto BuscarProducto (String _codigo)
        {
            foreach(DO_Producto producto in lista_Productos)
            {
                if (producto.codigo == _codigo)
                {
                    return producto;
                }
            }

            return new DO_Producto();
        }


    }
}
