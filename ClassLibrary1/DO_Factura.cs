using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Factura
    {
        private int codigoFactura;
        private String notas;
        private String estado;
        private String tipoPago;
        private List<DO_Producto> listaProducto;
        private DO_Usuario usuario;

        public DO_Factura()
        {
        }

        public DO_Factura(int _codigoFactura, String _notas, String _estado, String _tipoPago, 
            List<DO_Producto> _listaProducto, DO_Usuario _usuario)
        {
            this.codigoFactura = _codigoFactura;
            this.notas = _notas;
            this.estado = _estado;
            this.tipoPago = _tipoPago;
            this.listaProducto = _listaProducto;
            this.usuario = _usuario;
        }
    }
}
