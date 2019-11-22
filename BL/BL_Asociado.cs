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
    }
}
