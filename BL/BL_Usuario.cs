using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
using DAO;


namespace BL
{
    public class BL_Usuario
    {
        /// <summary>
        /// Carga los usuarios registrados
        /// </summary>
        /// <returns>Lista con los usuarios registrados (List<DO_Usuario>)</returns>
        public List<DO_Usuario> CargarUsuarios()
        {
            DAO_Usuario daoUsuario = new DAO_Usuario();

            return daoUsuario.CargarUsuarios();
        }

        public bool insertarUsuario(string nombre, string tipo, string clave)
        {
            DAO_Usuario daoUsuario = new DAO_Usuario();
            return daoUsuario.crearUsuario(nombre, tipo, clave);
        }

        public bool actualizarUsuario(string usuario, string tipo, string contrasena)
        {
            DAO_Usuario daoUsuario = new DAO_Usuario();
            return daoUsuario.actualizarUsuario(usuario, tipo, contrasena);
        }
        public DO_Usuario iniciarSesion(String usuario, String contrasena) {
            DAO_Usuario daoUsuario = new DAO_Usuario();
            return daoUsuario.iniciarSesion(usuario, contrasena);
        }
    }
}
