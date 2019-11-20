using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DO;

namespace BL
{
    public class BL_Persona
    {
        public int registrarPersona(DO_Persona persona) {
            DAO_Persona daoPersona = new DAO_Persona();
            return daoPersona.registrarPersona(persona);
        }
    }
}
