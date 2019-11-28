using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{

    public class DO_ProveedorParaHorario
    {
        public String nombre { set; get; }
        public List<String> listaDiaYhora { set; get; }

        public DO_ProveedorParaHorario()
        {
            listaDiaYhora = new List<string>();
        }
    }
}
