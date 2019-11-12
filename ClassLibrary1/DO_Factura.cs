using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Factura
    {
        private int codigoFactura { set; get; }
        private String notas { set; get; }
        private String estado { set; get; }
        private String tipoPago { set; get; }
        private List<DO_Producto> listaProducto { set; get; }
        private DO_Usuario usuario { set; get; }

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
