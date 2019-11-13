using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class DO_Factura
    {
        public int codigoFactura { set; get; }
        public String notas { set; get; }
        public String estado { set; get; }
        public String tipoPago { set; get; }
        public DateTime fecha { set; get; }
        public String clienteExterno { set; get; }
        public List<DO_Producto> listaProducto { set; get; }
        public string usuario { set; get; }
        public int codigoPlantilla { set; get; }
        public int credito { set; get; }

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
