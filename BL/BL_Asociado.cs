using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
using DAO;

namespace BL
{
    public class BL_Asociado
    {
        public bool AgregarAsociado(DO_Asociado nuevoAsociado)
        {
            DAO_Persona daoPersona = new DAO_Persona();
            DAO_Asociado daoAsociado = new DAO_Asociado();

            nuevoAsociado.perIdentificador = daoPersona.registrarPersona(nuevoAsociado);

            if (daoAsociado.AgregarAsociado(nuevoAsociado))
            {
                return true;
            }

            return false;
        }

        public List<DO_Asociado> obtenerListaAsociados(String proveedor)
        {
            DAO_Asociado daoAsociado = new DAO_Asociado();
            return daoAsociado.ObtenerAsociados(proveedor);
        }

        public bool eliminarAsociado(int idAsociado)
        {
            DAO_Asociado daoAsociado = new DAO_Asociado();
            return daoAsociado.EliminarAsociado(idAsociado);
        }

        public DO_Asociado buscarAsociado(int idAsociado)
        {
            DAO_Asociado daoAsociado = new DAO_Asociado();
            return daoAsociado.BuscarAsociado(idAsociado+"");
        }

        public bool editarAsociado(DO_Asociado asociado)
        {
            DAO_Asociado daoAsociado = new DAO_Asociado();
            return daoAsociado.editarAsociado(asociado);
        }
    }
}
