using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    //cambio
    public class DO_PlantillaFactura
    {
        public int codigo { set; get; }
        public String numeroTelefono { set; get; }
        public String nombreEmpresa { set; get; }
        public String direccion { set; get; }
        public String cedula { set; get; }
        public int turno { set; get; }
        public int folio { set; get; }

        public DO_PlantillaFactura()
        {
        }

        public DO_PlantillaFactura(int _codigo, String _numeroTelefono, String _nombreEmpresa, String _direccion, 
            String _cedula, int _turno, int _folio)
        {
            this.codigo = _codigo;
            this.numeroTelefono = _numeroTelefono;
            this.nombreEmpresa = _nombreEmpresa;
            this.direccion = _direccion;
            this.cedula = _cedula;
            this.turno = _turno;
            this.folio = _folio;
        }
    }
}
